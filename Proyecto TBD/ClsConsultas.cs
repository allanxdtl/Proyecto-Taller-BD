using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Windows.Forms;

namespace Proyecto_TBD
{
	internal class ClsConsultas
	{
		private SqlConnection con;
		private SqlCommand cmd;
		private SqlDataReader reader;
		private SqlDataAdapter adapter;

		public ClsConsultas(string cadena_conexion)
		{
			con = new SqlConnection(cadena_conexion);
		}

		public DataTable ConsultaNormal(string consulta)
		{
			DataTable dt = new DataTable();
			try
			{
				cmd = new SqlCommand(consulta, con);
				adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);
			}
			catch (SqlException)
			{
				MessageBox.Show($"Ocurrio un error en la consulta, verifiquela\n{consulta}", "Error al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return dt;
		}

		public SqlDataReader ConsultaNormalReader(string consulta)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand(consulta, con);
				reader = cmd.ExecuteReader();
			}
			catch (SqlException)
			{
				MessageBox.Show($"Ocurrio un error en la consulta, verifiquela\n{consulta}", "Error al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return reader;
		}

		public void CerrarConexion()
		{
			con.Close();
		}

		public void Insertar(string consulta)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand(consulta, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Se ha insertado correctamente el registro", "Registro exitoso",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (SqlException sql)
			{
				if (sql.Message.Contains("PRIMARY KEY"))
				{
					MessageBox.Show("Ya existe un registro con ese identificador en la base de datos, cambielo", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show(sql.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			finally
			{
				con.Close();
			}
		}

		public void Actualizar(string consulta)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand(consulta, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Se han actualizado el registro correctamente", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (SqlException)
			{
				MessageBox.Show("Ocurrio un error, verifique los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				con.Close();
			}
		}

		public void Eliminar(string consulta)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand(consulta, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("El registro ha sido elminado exitosamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (SqlException ex)
			{
				if (ex.Message.Contains("fk"))
					MessageBox.Show("Este registro no puede ser eliminado debido a que esta conectado a otro registro", "No fue posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show("Ocurrio un error, verifique la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				con.Close();
			}
		}

		public string HacerCabeceraPedimento(int patente, string importador, double total, int ciudad, DateTime fecha, DataGridView productos)
		{
			string idPedimento = "";
			idPedimento += fecha.Year.ToString().Substring(2, 2) + " ";
			idPedimento += ciudad + " ";
			idPedimento += patente + " ";
			Random rnd = new Random();
			for (int i = 0; i < 7; i++)
			{
				idPedimento += rnd.Next(0, 10);
			}

			//-----------------STORED PROCEDURE------------------------

			cmd = new SqlCommand("Sp_RegistrarNuevoPedimentoHeader ", con);
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@IDPedimento", SqlDbType.VarChar).Value = idPedimento;
			cmd.Parameters.Add("@Agente", SqlDbType.Int).Value = patente;
			cmd.Parameters.Add("@Importador", SqlDbType.VarChar).Value = importador;
			cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = total;
			cmd.Parameters.Add("@Aduana", SqlDbType.Int).Value = ciudad;
			cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;

			cmd.ExecuteNonQuery();
			con.Close();

			MessageBox.Show("Se ha generado correctamente el encabezado del pedimento");
			for (int i = 0; i < productos.Rows.Count; i++)
			{
				InsertarEnPedimentoDetail(idPedimento, productos.Rows[i].Cells[0].Value.ToString(), int.Parse(productos.Rows[i].Cells[3].Value.ToString()));
			}
			MessageBox.Show("Se han terminado de insertar los articulos en el pedimento");


			return "Se ha generado el pedimento con el identificador " + idPedimento;
		}

		private void InsertarEnPedimentoDetail(string idpedimento, string articulo, int cantidad)
		{
			//-----------------STORED PROCEDURE------------------------
			cmd = new SqlCommand("Sp_RegistrarNuevoPedimentoDetail", con);
			con.Open();

			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@idPedimento", SqlDbType.VarChar).Value = idpedimento;
			cmd.Parameters.Add("@Articulo", SqlDbType.VarChar).Value = articulo;
			cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad;


			cmd.ExecuteNonQuery();

			con.Close();
		}

		public DataSet ConsultarPedimento(string pedimento)
		{

			//-----------------STORED PROCEDURE------------------------
			cmd = new SqlCommand("SP_getPedimento", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@IDPedimento", SqlDbType.VarChar).Value = pedimento;
			con.Open();
			adapter = new SqlDataAdapter(cmd);
			DataSet resultados = new DataSet();
			adapter.Fill(resultados);
			con.Close();
			return resultados;
		}

		//te regresa un true si el usuario y la contraseña son verdaderas, o false si el usuario o la contraseña son incorrectos
		public static bool Login(string username, string password)
		{

			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["super"].ToString());
			try
			{
				con.Open();

				SqlCommand sqlCommand = new SqlCommand("spLogin", con)
				{
					CommandType = CommandType.StoredProcedure
				};
				sqlCommand.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = username;
				sqlCommand.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = password;

				SqlDataReader r = sqlCommand.ExecuteReader();

				if (r.Read())
				{
					//guardamos el tipo de usuario que se hizo login en el archivo de configuracion
					Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
					config.AppSettings.Settings["tipo_User"].Value = r.GetString(2);
					config.Save(ConfigurationSaveMode.Modified); config.Save(ConfigurationSaveMode.Modified);

					MessageBox.Show($"Inicio exitoso, bienvenido {username}",
					"Sesion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}

				MessageBox.Show("No se encontro tu usuario o la contraseña es incorrecta, vuelve a verificar tus entradas",
					"NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (SqlException)
			{
				MessageBox.Show("Ocurrio un error al intentar conectar a la base de datos," +
					" verifique que esté activo el servidor o los servicios", "No se pudo conectar a la base de datos",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}

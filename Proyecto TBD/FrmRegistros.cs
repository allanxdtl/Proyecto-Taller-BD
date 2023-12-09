using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_TBD
{
	public partial class FrmRegistros : Form
	{
		ClsConsultas consultas;
		DataTable aduanasIDyCiudad;

		public FrmRegistros()
		{
			InitializeComponent();

			//aqui van las condiciones para los usuarios, dependiendo de su rol, es lo que podran hacer
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			if (config.AppSettings.Settings["tipo_User"].Value == "admin")
			{
				consultas = new ClsConsultas(ConfigurationManager.ConnectionStrings["sudo"].ToString());
			}
			else
			{
				consultas = new ClsConsultas(ConfigurationManager.ConnectionStrings["read"].ToString());
				BtnEditar.Enabled = false;
				BtnEliminar.Enabled = false;
				BtnEditarAgente.Enabled = false;
				BtnEliminarAgente.Enabled = false;
				BtnActualizarImportador.Enabled = false;
				BtnEliminarImportador.Enabled = false;
				BtnEditarArticulo.Enabled = false;
				BtnEliminarArticulo.Enabled = false;
			}

			LlenarCmbAgentesAduanales();

		}

		//llenado del comboBox de Agentes Aduanales
		public void LlenarCmbAgentesAduanales()
		{
			cmbAgencias.Items.Clear();
			aduanasIDyCiudad = consultas.ConsultaNormal("select ID, Ciudad from Aduanas order by Ciudad asc");
			for (int i = 0; i < aduanasIDyCiudad.Rows.Count; i++)
			{
				cmbAgencias.Items.Add(aduanasIDyCiudad.Rows[i]["Ciudad"].ToString());
			}
		}

		private void MostrarRegistros(Button f)
		{
			if (f.Name == "BtnBuscar" || f.Name == "BtnEditar" || f.Name == "BtnAgregar" || f.Name == "BtnEliminar")
			{
				string con = "select * from Aduanas where ";
				con += txtIDAduana.Text == "" ? " ID like '' or " : $"ID like '%{txtIDAduana.Text}%' or ";
				con += txtCiudadAduana.Text == "" ? "ciudad like '' or " : $"ciudad like '%{txtCiudadAduana.Text}%' or ";
				con += TxtDireccionAduana.Text == "" ? "Direccion like ''" : $"Direccion like '%{TxtDireccionAduana.Text}%'";
				registros_aduanas.DataSource = consultas.ConsultaNormal(con);
			}
			else if (f.Name == "BtnBuscarAgentes" || f.Name == "BtnEditarAgente" || f.Name == "BtnAgregarAgente")
			{
				string con = "select patente, A.Ciudad as CiudadDondeTrabaja , " +
				"isnull(Nombre, '')+' '+isnull(ApellidoPaterno, '')+' '+isnull(apellidoMaterno, '') as NombreCompleto, " +
				"AA.RFC " +
				"from AgentesAduanales AA inner join Aduanas A on AA.AgenciaAduanal=A.ID where ";
				con += TxtIDAgente.Text == "" ? "patente='' or " : $"patente like '%{TxtIDAgente.Text}%' or ";
				con += TxtNombreAgente.Text == "" ? "Nombre='' or " : $"Nombre like '%{TxtNombreAgente.Text}%' or ";
				con += cmbAgencias.Text == "" ? "Ciudad=''" : $"A.Ciudad='{cmbAgencias.Text}'";
				registros_agentes.DataSource = consultas.ConsultaNormal(con);
			}
			else if (f.Name == "BtnBuscarImportadores" || f.Name == "BtnAgregarImportador")
			{
				registros_importadores.DataSource = consultas.ConsultaNormal("select * from importadores where " +
				$"IDImportador like '%{TxtRFCImportador.Text}%' and Nombre like '%{TxtNombreImportador.Text}%'");
			}
			else if (f.Name == "BtnVerRegistrosArticulos" || f.Name == "BtnAgregarArticulo" || f.Name == "BtnEliminarArticulo" || f.Name == "BtnBuscarArticulo")
			{
				string con = "select * from Articulos ";
				con += TxtIDArticulo.Text == "" ? "where IDArticulo='' " : $"where IDArticulo like '%{txtNombreArticulo.Text}%' ";
				con += txtNombreArticulo.Text == "" ? "or Nombre='' " : $" or Nombre like '%{txtNombreArticulo.Text}%' ";
				con += txtPrecioArticulo.Text == "" ? "" : $"or precio={txtPrecioArticulo.Text}";
				registros_articulos.DataSource = consultas.ConsultaNormal(con);
			}

		}

		private void BtnVerTodo_Click(object sender, EventArgs e)
		{
			registros_aduanas.DataSource = consultas.ConsultaNormal("select * from aduanas");
		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			MostrarRegistros((Button)sender);
		}

		private void registros_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				txtIDAduana.Text = registros_aduanas.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtCiudadAduana.Text = registros_aduanas.Rows[e.RowIndex].Cells[1].Value.ToString();
				TxtDireccionAduana.Text = registros_aduanas.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtIDAduana.Enabled = false;
			}
		}

		private void BtnEditar_Click(object sender, EventArgs e)
		{
			consultas.Actualizar("update Aduanas " +
				$"set Ciudad='{txtCiudadAduana.Text}', Direccion='{TxtDireccionAduana.Text}' " +
				$"where ID='{txtIDAduana.Text}'");
			MostrarRegistros((Button)sender);
			//registros_aduanas.DataSource = consultas.ConsultaNormal($"select * from aduanas where ID='{TxtRFC.Text}'");
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{
			if (txtIDAduana.Text != "")
			{
				if (MessageBox.Show("¿Estas seguro que deseas elminar el registro? Una vez elminado no se podra recuperar",
				"¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					consultas.Eliminar($"delete from Aduanas where ID='{txtIDAduana.Text}'");
				}
			}
			else
				MessageBox.Show("Asegurese de selccionar un registro de la tabla", "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			MostrarRegistros((Button)sender);
		}

		private void BtnLimpiar_Click(object sender, EventArgs e)
		{
			txtIDAduana.Text = "";
			txtCiudadAduana.Text = "";
			TxtDireccionAduana.Text = "";
			txtIDAduana.Enabled = true;
			registros_aduanas.DataSource = null;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			consultas.Insertar($"insert into Aduanas values ('{txtIDAduana.Text}', '{txtCiudadAduana.Text}', '{TxtDireccionAduana.Text}')");
			MostrarRegistros((Button)sender);
			LlenarCmbAgentesAduanales();
		}

		private void txtVerRegistrosAgentes_Click(object sender, EventArgs e)
		{
			registros_agentes.DataSource = consultas.ConsultaNormal("select patente, A.Ciudad as CiudadDondeSeUbica , " +
				"isnull(Nombre, '')+' '+isnull(ApellidoPaterno, '')+ ' '+isnull(apellidoMaterno, '') as NombreCompleto, " +
				"AA.RFC " +
				"from AgentesAduanales AA inner join Aduanas A on AA.AgenciaAduanal=A.ID");
		}

		private void BtnBuscarAgentes_Click(object sender, EventArgs e)
		{
			MostrarRegistros((Button)sender);
		}

		private void registros_agentes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				SqlDataReader read = consultas.ConsultaNormalReader("select * from AgentesAduanales where" +
						$" patente={registros_agentes.Rows[e.RowIndex].Cells[0].Value}");
				read.Read();
				cmbAgencias.Text = registros_agentes.Rows[e.RowIndex].Cells[1].Value.ToString();
				TxtIDAgente.Text = registros_agentes.Rows[e.RowIndex].Cells[0].Value.ToString();
				TxtNombreAgente.Text = read.GetString(2);
				TxtApellidoPAgente.Text = read.GetString(3);
				TxtApellidoMAgente.Text = read.IsDBNull(4) ? "" : read.GetString(4);
				TxtRFCAgente.Text = read.GetString(5);

				TxtIDAgente.Enabled = false;

				consultas.CerrarConexion();
			}

		}

		private void BtnEliminarAgente_Click(object sender, EventArgs e)
		{
			if (TxtIDAgente.Text != "")
			{
				if (MessageBox.Show("¿Estas seguro que deseas elminar el registro? Una vez elminado no se podra recuperar",
				"¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					consultas.Eliminar($"delete from AgentesAduanales where patente={TxtIDAgente.Text}");
				}
				else
					MessageBox.Show("Asegurese de selccionar un registro de la tabla", "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			MostrarRegistros((Button)sender);
		}

		private void BtnAgregarAgente_Click(object sender, EventArgs e)
		{
			consultas.Insertar("insert into AgentesAduanales (PATENTE, AgenciaAduanal, Nombre, ApellidoPaterno, ApellidoMaterno, RFC)" +
				$" values ({TxtIDAgente.Text}, '{aduanasIDyCiudad.Rows[cmbAgencias.SelectedIndex]["id"]}', '{TxtNombreAgente.Text}', '{TxtApellidoPAgente.Text}'," +
				$"'{TxtApellidoMAgente.Text}', '{TxtRFCAgente.Text}')");
			MostrarRegistros((Button)sender);
		}

		private void BtnEditarAgente_Click(object sender, EventArgs e)
		{
			consultas.Actualizar($"update AgentesAduanales set AgenciaAduanal='{aduanasIDyCiudad.Rows[cmbAgencias.SelectedIndex]["ID"]}'," +
				$"Nombre='{TxtNombreAgente.Text}', ApellidoPaterno='{TxtApellidoPAgente.Text}', ApellidoMaterno='{TxtApellidoMAgente.Text}', RFC='{TxtRFCAgente.Text}' " +
				$"where patente='{TxtIDAgente.Text}'");
			MostrarRegistros((Button)sender);
			TxtIDAgente.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			registros_agentes.DataSource = null;
			TxtIDAgente.Text = "";
			cmbAgencias.Text = string.Empty;

		}

		private void BtnVerRegistrosImportadores_Click(object sender, EventArgs e)
		{
			registros_importadores.DataSource = consultas.ConsultaNormal("select * from importadores");
		}

		private void BtnLimpiarImportadores_Click(object sender, EventArgs e)
		{
			registros_importadores.DataSource = null;
			TxtRFCImportador.Enabled = true;
		}

		private void BtnBuscarImportadores_Click(object sender, EventArgs e)
		{
			MostrarRegistros((Button)sender);
		}

		private void BtnActualizarImportador_Click(object sender, EventArgs e)
		{
			consultas.Actualizar($"update Importadores set Nombre='{TxtNombreImportador.Text}' " +
				$"where IDImportador='{TxtRFCImportador.Text}'");
			consultas.ConsultaNormal($"select * from Importadores where IDImportador='{TxtRFCImportador.Text}'");
			TxtRFCImportador.Enabled = true;
		}

		private void BtnEliminarImportador_Click(object sender, EventArgs e)
		{
			if (TxtRFCImportador.Text != "")
			{
				if (MessageBox.Show("¿Estas seguro que deseas elminar el registro? Una vez elminado no se podra recuperar",
				"¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					consultas.Eliminar($"delete from Importadores where IDImportador='{TxtRFCImportador.Text}'");
				}
				else
					MessageBox.Show("Asegurese de selccionar un registro de la tabla", "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void BtnAgregarImportador_Click(object sender, EventArgs e)
		{
			consultas.Insertar($"insert into Importadores values ('{TxtRFCImportador.Text}', '{TxtNombreImportador.Text}')");
			MostrarRegistros((Button)sender);
		}

		private void registros_importadores_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				TxtRFCImportador.Enabled = false;
				TxtRFCImportador.Text = registros_importadores.Rows[e.RowIndex].Cells[0].Value.ToString();
				TxtNombreImportador.Text = registros_importadores.Rows[e.RowIndex].Cells[1].Value.ToString();
			}
		}

		private void BtnVerRegistrosProductos_Click(object sender, EventArgs e)
		{
			registros_articulos.DataSource = consultas.ConsultaNormal("select * from Articulos");
		}

		private void BtnAgregarArticulo_Click(object sender, EventArgs e)
		{
			consultas.Insertar($"insert into Articulos values ('{TxtIDArticulo.Text}', '{txtNombreArticulo.Text}', {txtPrecioArticulo.Text})");
			MostrarRegistros((Button)sender);
			TxtIDArticulo.Text = null;
			txtNombreArticulo.Text = null;
		}

		private void registros_productos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				TxtIDArticulo.Text = registros_articulos.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNombreArticulo.Text = registros_articulos.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtPrecioArticulo.Text = registros_articulos.Rows[e.RowIndex].Cells[2].Value.ToString();
				TxtIDArticulo.Enabled = false;
			}
		}

		private void BtnEliminarArticulo_Click(object sender, EventArgs e)
		{
			if (TxtIDArticulo.Text != "")
			{
				if (MessageBox.Show("¿Estas seguro que deseas elminar el registro? Una vez elminado no se podra recuperar",
				"¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					consultas.Eliminar($"delete from Articulos where IDArticulo='{TxtIDArticulo.Text}'");
				}
				else
					MessageBox.Show("Asegurese de selccionar un registro de la tabla", "Seleccione un registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				MostrarRegistros((Button)sender);
				txtNombreArticulo.Text = "";
				TxtIDArticulo.Text = "";
			}
		}

		private void BtnLimpiarArticulos_Click(object sender, EventArgs e)
		{
			txtNombreArticulo.Text = "";
			TxtIDArticulo.Text = "";
			txtPrecioArticulo.Text = "";
			registros_articulos.DataSource = null;
			TxtIDArticulo.Enabled = true;
		}

		private void BtnEditarArticulo_Click(object sender, EventArgs e)
		{
			if (TxtIDArticulo.Text != "")
			{
				consultas.Actualizar("update Articulos set " +
					$"Nombre='{txtNombreArticulo.Text}', Precio={txtPrecioArticulo.Text}" +
					$" where IdArticulo='{TxtIDArticulo.Text}'");
				TxtIDArticulo.Enabled = true;
				TxtIDArticulo.Text = null;
				txtNombreArticulo.Text = null;
			}
			else
			{
				MessageBox.Show("Seleccione un registro de la tabla para editarlo");
			}
		}

		private void BtnBuscarArticulo_Click(object sender, EventArgs e)
		{
			MostrarRegistros((Button)sender);
		}
	}
}

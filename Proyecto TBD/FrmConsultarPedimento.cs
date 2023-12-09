using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using SpreadsheetLight;
using System.Data.SqlClient;
using ZXing;
using System.Drawing;
using SpreadsheetLight.Drawing;
using System.IO;
using ZXing.Common;

namespace Proyecto_TBD
{
	public partial class FrmConsultarPedimento : Form
	{
		public FrmConsultarPedimento()
		{
			InitializeComponent();
			consultas = new ClsConsultas(ConfigurationManager.ConnectionStrings["super"].ToString());
		}

		public FrmConsultarPedimento(string idPedimento)
		{
			InitializeComponent();
			consultas = new ClsConsultas(ConfigurationManager.ConnectionStrings["super"].ToString());
			DataSet resultados = consultas.ConsultarPedimento(idPedimento);
			DataTable cabecera = resultados.Tables[0];
			DataTable productos = resultados.Tables[1];
			productosEnPedimento.DataSource = productos;

			if (cabecera.Rows.Count > 0)
			{
				lblPedimento.Text = cabecera.Rows[0][0].ToString();
				lblAgente.Text = cabecera.Rows[0][1].ToString();
				lblImportador.Text = cabecera.Rows[0][2].ToString();
				lblAduana.Text = cabecera.Rows[0][3].ToString();
				lblFecha.Text = cabecera.Rows[0][4].ToString();
				lblTotal.Text = cabecera.Rows[0][5].ToString();
				BtnDescargarPedimento.Visible = true;
			}

			BtnConsultar.Enabled = false;
			txtNoPedimento.Enabled = false;
			BtnLimpiar.Enabled = false;
		}

		readonly ClsConsultas consultas;

		private void txtNoPedimento_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Back)
			{
				if (txtNoPedimento.Text.Length == 2)
				{
					txtNoPedimento.Text += " ";
					txtNoPedimento.Select(txtNoPedimento.Text.Length, 0);
				}
				if (txtNoPedimento.Text.Length == 5)
				{
					txtNoPedimento.Text += " ";
					txtNoPedimento.Select(txtNoPedimento.Text.Length, 0);
				}
				if (txtNoPedimento.Text.Length == 10)
				{
					txtNoPedimento.Text += " ";
					txtNoPedimento.Select(txtNoPedimento.Text.Length, 0);
				}
			}
		}

		private void BtnConsultar_Click(object sender, EventArgs e)
		{
			DataSet resultados = consultas.ConsultarPedimento(txtNoPedimento.Text);
			DataTable cabecera = resultados.Tables[0];
			DataTable productos = resultados.Tables[1];
			productosEnPedimento.DataSource = productos;

			if (cabecera.Rows.Count > 0)
			{
				lblPedimento.Text = cabecera.Rows[0][0].ToString();
				lblAgente.Text = cabecera.Rows[0][1].ToString();
				lblImportador.Text = cabecera.Rows[0][2].ToString();
				lblAduana.Text = cabecera.Rows[0][3].ToString();
				lblFecha.Text = cabecera.Rows[0][4].ToString();
				lblTotal.Text = cabecera.Rows[0][5].ToString();
				BtnDescargarPedimento.Visible = true;
			}
			else
			{
				MessageBox.Show("No se ha encontrado un pedimento con ese numero de pedimento",
					"No se encontro pedimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}

		private void BtnLimpiar_Click(object sender, EventArgs e)
		{
			lblPedimento.Text = "";
			lblAgente.Text = "";
			lblImportador.Text = "";
			lblAduana.Text = "";
			lblFecha.Text = "";
			lblTotal.Text = "";
			productosEnPedimento.DataSource = null;
			BtnDescargarPedimento.Visible = false;
		}

		private void BtnDescargarPedimento_Click(object sender, EventArgs e)
		{
			using (SLDocument documento = new SLDocument())
			{
				//Configuraciones de la pagina
				SLPageSettings sLPage = new SLPageSettings();
				sLPage.PrintGridLines = false;
				sLPage.ShowGridLines = false;

				SLStyle estilos = new SLStyle();
				estilos.Font.FontSize = 16;
				estilos.Font.Bold = true;
				estilos.Font.FontName = "Arial";

				SqlDataReader read = consultas.ConsultaNormalReader($"select Agente from PedimentosHeader where IDPedimento='{lblPedimento.Text}'");
				read.Read();


				//Insercion de los datos en el documento
				documento.SetCellValue(1, 5, "PEDIMENTO"); documento.SetCellStyle(1, 5, estilos);

				documento.SetCellValue(3, 1, "No. de pedimento"); 
				documento.SetCellValue(3, 3, lblPedimento.Text);
				documento.SetCellValue(4, 1, "Agente Aduanal:"); 
				documento.SetCellValue(4, 3, lblAgente.Text); 
				documento.SetCellValue(4, 7, "Patente: "); 
				documento.SetCellValue(4, 8, read.GetInt32(0));
				documento.SetCellValue(5, 1, "Importador:"); 
				documento.SetCellValue(5, 3, lblImportador.Text);
				documento.SetCellValue(6, 1, "Aduana de arrivo:"); 
				documento.SetCellValue(6, 3, lblAduana.Text);
				documento.SetCellValue(7, 1, "Fecha de operacion:"); 
				documento.SetCellValue(7, 3, lblFecha.Text);


				documento.SetCellValue(9, 4, "Lista de articulos en el pedimento");
				documento.SetCellValue(9, 1, "Nombre"); documento.SetCellValue(9, 3, "Precio"); 
				documento.SetCellValue(9, 4, "Cantidad"); documento.SetCellValue(9, 5, "Subtotal");
				int fila = 10;
				int filaTabla = 0;
				for (int i = fila; i < 10 + productosEnPedimento.Rows.Count - 1; i++)
				{
					documento.SetCellValue(fila, 1, productosEnPedimento.Rows[filaTabla].Cells[0].Value.ToString());
					documento.SetCellValueNumeric(fila, 3, productosEnPedimento.Rows[filaTabla].Cells[1].Value.ToString());
					documento.SetCellValueNumeric(fila, 4, productosEnPedimento.Rows[filaTabla].Cells[2].Value.ToString());
					documento.SetCellValueNumeric(fila, 5, productosEnPedimento.Rows[filaTabla++].Cells[3].Value.ToString());
					fila++;
				}
				documento.SetCellValue(fila, 6, "Total:");
				documento.SetCellValueNumeric(fila, 7, lblTotal.Text);

				BarcodeWriter codigo = new BarcodeWriter()
				{
					Format = BarcodeFormat.CODE_93,
					Options = new EncodingOptions
					{
						Height = 50,
						Width = 150
					}
				};
				Bitmap code = codigo.Write(lblPedimento.Text);
				code.Save("co.png");

				SLPicture imagen = new SLPicture("co.png");
				imagen.SetPosition(fila + 2, 2);
				documento.SetCellValue(fila + 7, 1, "Utilice este codigo de barra para pagar en el banco");

				documento.InsertPicture(imagen);
				consultas.CerrarConexion();

				//Guardado del documento
				SaveFileDialog guardar = new SaveFileDialog();
				guardar.DefaultExt = ".xlsx";
				guardar.FileName = $"pedimento {lblPedimento.Text} del {lblFecha.Text}";
				if (guardar.ShowDialog() == DialogResult.OK)
				{
					documento.SetPageSettings(sLPage);
					documento.SaveAs(guardar.FileName);
					MessageBox.Show("Se ha guardado el documento", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (MessageBox.Show("¿Deseas abrir el archivo?", "¿Abrir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Process.Start(guardar.FileName);
					}
				}

				File.Delete("co.png");
			}
		}
	}
}

using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;
using Aspose.Cells.Charts;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;

namespace Proyecto_TBD
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			if (config.AppSettings.Settings["tipo_User"].Value == "read")
			{
				BtnHacerPedimento.Enabled = false;
			}
		}

		private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estas seguro que deseas salir de la aplicacion?", "Seguro?"
				, MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estas seguro que deseas cerrar sesión?", "Seguro?"
				, MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
			{
				Application.Restart();
			}
		}

		private void BtnRegistros_Click(object sender, EventArgs e)
		{
			FrmRegistros registros = new FrmRegistros();
			registros.Show();
		}

		private void BtnConsultarPedimento_Click(object sender, EventArgs e)
		{
			new FrmConsultarPedimento().Show();
		}

		private void BtnHacerPedimento_Click(object sender, EventArgs e)
		{
			new FrmMakePedimento().Show();
		}

		private void BtnPedimentosPorFecha_Click(object sender, EventArgs e)
		{
			new FrmConsultaPorFecha().Show();
		}

		private void BtnConsultarPorProducto_Click(object sender, EventArgs e)
		{
			new FrmConsultarPorProducto().Show();
		}

		private void BtnPedimentoPorAduana_Click(object sender, EventArgs e)
		{
			new FrmConsultarPorAduana().Show();
		}

		private void BtnConsultarImportador_Click(object sender, EventArgs e)
		{
			new FrmConsultarPorImportador().Show();
		}

		private void BtnShowProductos_Click(object sender, EventArgs e)
		{
			DataTable consult = new ClsConsultas(ConfigurationManager.ConnectionStrings["super"].ToString()).
				ConsultaNormal("select A.Nombre as 'Nombre del Articulo', sum(PD.Cantidad) as 'Total exportados/importados' " +
				"from Articulos A inner join PedimentosDetail PD " +
				"on A.IDArticulo=PD.IDArticulo " +
				"group by A.Nombre " +
				"order by 'Total exportados/importados' desc");


			Workbook excel = new Workbook();
			Worksheet hoja = excel.Worksheets[0];
			hoja.Name = "Productos mas importados/exportados";
			ImportTableOptions importOptions = new ImportTableOptions();
			hoja.Cells.ImportData(consult, 0, 0, importOptions);

			Chart grafica = hoja.Charts[hoja.Charts.Add(ChartType.Pie, 10, 2, 34, 13)];
			grafica.NSeries.Add($"B2:B{consult.Rows.Count+1}", true);
			grafica.NSeries.CategoryData = $"A2:A{consult.Rows.Count+1}";
			grafica.Title.Text = "Productos con mas importaciones/exportaciones";
			grafica.Title.Font.Color = Color.Blue;
			grafica.Title.Font.IsBold = true;
			grafica.Title.Font.Size = 14;

			DataLabels data_labels;
			for (int i = 0; i < grafica.NSeries.Count; i++)
			{
				data_labels = grafica.NSeries[i].DataLabels;
				data_labels.ShowValue = true;
				data_labels.ShowPercentage = false;

			}

			SaveFileDialog guardar = new SaveFileDialog();
			guardar.FileName = $"Productos mas importados-exportados de {DateTime.Now.Day} de {DateTime.Now.Month}.xlsx";
			if (guardar.ShowDialog() == DialogResult.OK)
			{
				excel.Save(guardar.FileName);
				if (MessageBox.Show("Se ha guardado exitosamente el archivo, ¿Deseas abrirlo?", "Proceso exitoso",
					MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					Process.Start(guardar.FileName);
				}
				
			}


		}
	}
}

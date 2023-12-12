using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Proyecto_TBD
{
	public partial class FrmConsultaPorFecha : Form
	{
		public FrmConsultaPorFecha()
		{
			InitializeComponent();
		}

		private void fecha_ValueChanged(object sender, EventArgs e)
		{
			//-----------------STORED PROCEDURE------------------------
			pedimentos.DataSource = new ClsConsultas(ConfigurationManager.ConnectionStrings["super"].ToString())
				.ConsultaNormal($"exec sp_BuscarPorFecha {fecha.Value.Day}, {fecha.Value.Month}, {fecha.Value.Year}");
		}

		private void pedimentos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				new FrmConsultarPedimento(pedimentos.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
			}
		}
	}
}

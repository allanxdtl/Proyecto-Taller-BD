using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TBD
{
	public partial class FrmConsultarPorImportador : Form
	{
		public FrmConsultarPorImportador()
		{
			InitializeComponent();
			consultas = new ClsConsultas(System.Configuration.ConfigurationManager.ConnectionStrings["super"].ToString());
			LlenarCmbImportadores();
		}

		public void LlenarCmbImportadores()
		{
			cmbImport.Items.Clear();
			importadores = consultas.ConsultaNormal("select IDIMportador, Nombre from Importadores order by Nombre");
			for (int i = 0; i < importadores.Rows.Count; i++)
			{
				cmbImport.Items.Add(importadores.Rows[i]["Nombre"].ToString());
			}
		}

		DataTable importadores;
		ClsConsultas consultas;

		private void cmbImport_SelectedIndexChanged(object sender, EventArgs e)
		{
			pedimentos.DataSource = consultas.ConsultaNormal("select IDPedimento, dbo.defNombreCompletoAgentes(AA.Patente) as Agente, cast(day(fecha) as varchar) + '/'+ cast(MONTH(fecha) as varchar)+'/'+ cast(year(fecha) as varchar) as 'Fecha de Expedicion'" +
				" from PedimentosHeader PH inner join Importadores I on PH.Importador=I.IDImportador " +
				"inner join AgentesAduanales AA on AA.Patente=PH.Agente " +
				$"where I.IDImportador='{importadores.Rows[cmbImport.SelectedIndex][0]}'");
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

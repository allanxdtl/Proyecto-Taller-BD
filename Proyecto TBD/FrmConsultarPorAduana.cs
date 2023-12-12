
using System.Data;
using System.Windows.Forms;

namespace Proyecto_TBD
{
	public partial class FrmConsultarPorAduana : Form
	{
		public FrmConsultarPorAduana()
		{
			InitializeComponent();
			consultas = new ClsConsultas(System.Configuration.ConfigurationManager.ConnectionStrings["super"].ToString());
			LlenarCmbAgentesAduanales();
		}

		ClsConsultas consultas;
		DataTable aduanasIDyCiudad;

		public void LlenarCmbAgentesAduanales()
		{
			cmbAduanas.Items.Clear();
			aduanasIDyCiudad = consultas.ConsultaNormal("select ID, Ciudad from Aduanas order by Ciudad asc");
			for (int i = 0; i < aduanasIDyCiudad.Rows.Count; i++)
			{
				cmbAduanas.Items.Add(aduanasIDyCiudad.Rows[i]["Ciudad"].ToString());
			}
		}

		private void pedimentos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
				new FrmConsultarPedimento(pedimentos.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
		}

		private void cmbAduanas_SelectedIndexChanged(object sender, System.EventArgs e)
		{

			//-----------------------------------FUNCTION--------------------------------
			pedimentos.DataSource = consultas.ConsultaNormal("select idPedimento, dbo.defNombreCompletoAgentes(AA.Patente) as Agente, cast(day(fecha) as varchar) + '/'+ cast(MONTH(fecha) as varchar)+'/'+ cast(year(fecha) as varchar) as 'Fecha de Expedicion' " +
				"from PedimentosHeader PH inner join Aduanas A on A.ID=PH.Aduana" +
				" inner join AgentesAduanales AA on AA.Patente=PH.Agente" +
				$" where A.ID={aduanasIDyCiudad.Rows[cmbAduanas.SelectedIndex][0]}");
		}
	}
}

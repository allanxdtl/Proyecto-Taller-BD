﻿using System;
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
	public partial class FrmConsultarPorProducto : Form
	{
		DataTable productos;

		public FrmConsultarPorProducto()
		{
			InitializeComponent();
			LlenarCmbProductos();
		}

		ClsConsultas consultas;

		public void LlenarCmbProductos()
		{
			consultas = new ClsConsultas(ConfigurationManager.ConnectionStrings["super"].ToString());
			cmbProductos.Items.Clear();
			productos = consultas.ConsultaNormal("select IDArticulo, Nombre, Precio From Articulos order by Nombre");
			for (int i = 0; i < productos.Rows.Count; i++)
			{
				cmbProductos.Items.Add(productos.Rows[i]["Nombre"].ToString());
			}
		}

		private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
		{
			pedimentos.DataSource = consultas.ConsultaNormal("select PH.IDPedimento, dbo.defNombreCompletoAgentes(AA.Patente) as 'Agente', cast(day(PH.fecha) as varchar) + '/'+ cast(MONTH(PH.fecha) as varchar)+'/'+ cast(year(PH.fecha) as varchar) as 'Fecha de Expedicion' " +
				"from PedimentosDetail PD inner join Articulos A on PD.IDArticulo=A.IDArticulo " +
				"inner join PedimentosHeader PH on PH.IDPedimento=PD.IDPedimento " +
				"inner join AgentesAduanales AA on PH.Agente=AA.Patente " +
				$"where A.IDArticulo={productos.Rows[cmbProductos.SelectedIndex]["IDArticulo"]}");
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				new FrmConsultarPedimento(pedimentos.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
			}
		}
	}
}

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

namespace Proyecto_TBD
{
	public partial class FrmMakePedimento : Form
	{
		DataTable agentesAduanales;
		DataTable importadores;
		DataTable aduanasIDyCiudad;
		DataTable productos;
		ClsConsultas consultas;

		public FrmMakePedimento()
		{
			InitializeComponent();
			consultas = new ClsConsultas(ConfigurationManager.ConnectionStrings["super"].ToString());

			LLenarCMBAgentesAduanales();
			LlenarCmbImportadores();
			LlenarCmbCiudades();
			LlenarCmbProductos();
		}

		public void LLenarCMBAgentesAduanales()
		{
			cmbAgentes.Items.Clear();
			agentesAduanales = consultas.ConsultaNormal("select Patente, dbo.defNombreCompletoAgentes(Patente) as 'Nombre Completo'" +
				" from AgentesAduanales order by 'Nombre Completo' asc");
			for (int i = 0; i < agentesAduanales.Rows.Count; i++)
			{
				cmbAgentes.Items.Add(agentesAduanales.Rows[i]["Nombre Completo"].ToString());
			}
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

		public void LlenarCmbCiudades()
		{
			cmbCiudades.Items.Clear();
			aduanasIDyCiudad = consultas.ConsultaNormal("select ID, Ciudad from Aduanas order by Ciudad asc");
			for (int i = 0; i < aduanasIDyCiudad.Rows.Count; i++)
			{
				cmbCiudades.Items.Add(aduanasIDyCiudad.Rows[i]["Ciudad"].ToString());
			}
		}

		public void LlenarCmbProductos()
		{
			cmbProductos.Items.Clear();
			productos = consultas.ConsultaNormal("select IDArticulo, Nombre, Precio From Articulos order by Nombre");
			for (int i = 0; i < productos.Rows.Count; i++)
			{
				cmbProductos.Items.Add(productos.Rows[i]["Nombre"].ToString());
			}
		}

		public double CalcularSubtotal()
		{
			double total = 0;
			for (int i = 0; i < productosEnPedimento.Rows.Count - 1; i++)
			{
				total += double.Parse(productosEnPedimento.Rows[i].Cells[4].Value.ToString());
			}
			return total;
		}

		private void BtnAddProducto_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < productosEnPedimento.Rows.Count; i++)
			{
				if (cmbProductos.Text == productosEnPedimento.Rows[i].Cells[1].Value.ToString())
				{
					productosEnPedimento.Rows[i].Cells[3].Value = int.Parse(productosEnPedimento.Rows[i].Cells[3].Value.ToString()) + int.Parse(txtCantidadArticulo.Text);
					productosEnPedimento.Rows[i].Cells[4].Value = double.Parse(productosEnPedimento.Rows[i].Cells[3].Value.ToString()) *
						double.Parse(productosEnPedimento.Rows[i].Cells[2].Value.ToString());
					lblSubtotal.Text = CalcularSubtotal().ToString();
					return;
				}
			}
			productosEnPedimento.Rows.Add(productos.Rows[cmbProductos.SelectedIndex]["IDArticulo"].ToString(),
				cmbProductos.Text, productos.Rows[cmbProductos.SelectedIndex]["Precio"].ToString(),
				txtCantidadArticulo.Text, double.Parse(txtCantidadArticulo.Text) * double.Parse(productos.Rows[cmbProductos.SelectedIndex]["Precio"].ToString()));
			lblSubtotal.Text = CalcularSubtotal().ToString();
		}

		private void BtnMakePedimento_Click(object sender, EventArgs e)
		{
			if (productosEnPedimento.Rows.Count > 1)
			{
				try
				{
					int patente = int.Parse(agentesAduanales.Rows[cmbAgentes.SelectedIndex]["Patente"].ToString());
					string importador = importadores.Rows[cmbImport.SelectedIndex]["IDImportador"].ToString();
					//con cargo del 20% de impuestos
					double total = int.Parse(lblSubtotal.Text) * 1.2;
					int aduana = int.Parse(aduanasIDyCiudad.Rows[cmbCiudades.SelectedIndex]["ID"].ToString());
					MessageBox.Show(consultas.HacerCabeceraPedimento(patente, importador, total, aduana, fecha.Value, productosEnPedimento),
						"Se ha generado el pedimento correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (IndexOutOfRangeException)
				{
					MessageBox.Show("Asegurate de seleccionar todos los campos correspondientes", "Cuidado",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Asegurate de agregar por lo menos un producto");
			}
		}
	}
}

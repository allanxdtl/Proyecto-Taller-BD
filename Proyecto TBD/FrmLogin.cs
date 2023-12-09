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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void BtnLog_Click(object sender, EventArgs e)
		{
			if(ClsConsultas.Login(txtUser.Text, txtPassword.Text))
			{
				FrmPrincipal principal = new FrmPrincipal();
				principal.Show();
				Hide();
			}
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			//aqui va la abertura de la forma para registrar nuevos usuarios
		}
	}
}

namespace Proyecto_TBD
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.BtnRegistros = new System.Windows.Forms.Button();
			this.BtnHacerPedimento = new System.Windows.Forms.Button();
			this.BtnConsultarPedimento = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnPedimentosPorFecha = new System.Windows.Forms.Button();
			this.BtnConsultarPorProducto = new System.Windows.Forms.Button();
			this.BtnPedimentoPorAduana = new System.Windows.Forms.Button();
			this.BtnConsultarImportador = new System.Windows.Forms.Button();
			this.BtnShowProductos = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label1.Location = new System.Drawing.Point(77, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(434, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecciona lo que deseas hacer";
			// 
			// BtnRegistros
			// 
			this.BtnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnRegistros.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnRegistros.Location = new System.Drawing.Point(63, 149);
			this.BtnRegistros.Name = "BtnRegistros";
			this.BtnRegistros.Size = new System.Drawing.Size(151, 107);
			this.BtnRegistros.TabIndex = 1;
			this.BtnRegistros.Text = "Ver registros";
			this.BtnRegistros.UseVisualStyleBackColor = false;
			this.BtnRegistros.Click += new System.EventHandler(this.BtnRegistros_Click);
			// 
			// BtnHacerPedimento
			// 
			this.BtnHacerPedimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnHacerPedimento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHacerPedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnHacerPedimento.Location = new System.Drawing.Point(220, 149);
			this.BtnHacerPedimento.Name = "BtnHacerPedimento";
			this.BtnHacerPedimento.Size = new System.Drawing.Size(151, 107);
			this.BtnHacerPedimento.TabIndex = 2;
			this.BtnHacerPedimento.Text = "Hacer pedimento";
			this.BtnHacerPedimento.UseVisualStyleBackColor = false;
			this.BtnHacerPedimento.Click += new System.EventHandler(this.BtnHacerPedimento_Click);
			// 
			// BtnConsultarPedimento
			// 
			this.BtnConsultarPedimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnConsultarPedimento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConsultarPedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnConsultarPedimento.Location = new System.Drawing.Point(377, 149);
			this.BtnConsultarPedimento.Name = "BtnConsultarPedimento";
			this.BtnConsultarPedimento.Size = new System.Drawing.Size(151, 107);
			this.BtnConsultarPedimento.TabIndex = 3;
			this.BtnConsultarPedimento.Text = "Consultar Pedimento";
			this.BtnConsultarPedimento.UseVisualStyleBackColor = false;
			this.BtnConsultarPedimento.Click += new System.EventHandler(this.BtnConsultarPedimento_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(593, 28);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.cerrarAplicacionToolStripMenuItem});
			this.opcionesToolStripMenuItem.Image = global::Proyecto_TBD.Properties.Resources.descarga;
			this.opcionesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.RosyBrown;
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// cerrarAplicacionToolStripMenuItem
			// 
			this.cerrarAplicacionToolStripMenuItem.Name = "cerrarAplicacionToolStripMenuItem";
			this.cerrarAplicacionToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
			this.cerrarAplicacionToolStripMenuItem.Text = "Cerrar aplicacion";
			this.cerrarAplicacionToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicacionToolStripMenuItem_Click);
			// 
			// BtnPedimentosPorFecha
			// 
			this.BtnPedimentosPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnPedimentosPorFecha.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPedimentosPorFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnPedimentosPorFecha.Location = new System.Drawing.Point(63, 278);
			this.BtnPedimentosPorFecha.Name = "BtnPedimentosPorFecha";
			this.BtnPedimentosPorFecha.Size = new System.Drawing.Size(193, 127);
			this.BtnPedimentosPorFecha.TabIndex = 11;
			this.BtnPedimentosPorFecha.Text = "Ver pedimentos por fecha";
			this.BtnPedimentosPorFecha.UseVisualStyleBackColor = false;
			this.BtnPedimentosPorFecha.Click += new System.EventHandler(this.BtnPedimentosPorFecha_Click);
			// 
			// BtnConsultarPorProducto
			// 
			this.BtnConsultarPorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnConsultarPorProducto.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConsultarPorProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnConsultarPorProducto.Location = new System.Drawing.Point(262, 278);
			this.BtnConsultarPorProducto.Name = "BtnConsultarPorProducto";
			this.BtnConsultarPorProducto.Size = new System.Drawing.Size(266, 127);
			this.BtnConsultarPorProducto.TabIndex = 12;
			this.BtnConsultarPorProducto.Text = "Ver pedimentos por producto";
			this.BtnConsultarPorProducto.UseVisualStyleBackColor = false;
			this.BtnConsultarPorProducto.Click += new System.EventHandler(this.BtnConsultarPorProducto_Click);
			// 
			// BtnPedimentoPorAduana
			// 
			this.BtnPedimentoPorAduana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnPedimentoPorAduana.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPedimentoPorAduana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnPedimentoPorAduana.Location = new System.Drawing.Point(63, 411);
			this.BtnPedimentoPorAduana.Name = "BtnPedimentoPorAduana";
			this.BtnPedimentoPorAduana.Size = new System.Drawing.Size(232, 127);
			this.BtnPedimentoPorAduana.TabIndex = 13;
			this.BtnPedimentoPorAduana.Text = "Ver pedimentos de cada aduana";
			this.BtnPedimentoPorAduana.UseVisualStyleBackColor = false;
			this.BtnPedimentoPorAduana.Click += new System.EventHandler(this.BtnPedimentoPorAduana_Click);
			// 
			// BtnConsultarImportador
			// 
			this.BtnConsultarImportador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnConsultarImportador.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConsultarImportador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnConsultarImportador.Location = new System.Drawing.Point(301, 411);
			this.BtnConsultarImportador.Name = "BtnConsultarImportador";
			this.BtnConsultarImportador.Size = new System.Drawing.Size(232, 127);
			this.BtnConsultarImportador.TabIndex = 14;
			this.BtnConsultarImportador.Text = "Ver pedimentos de cada importador";
			this.BtnConsultarImportador.UseVisualStyleBackColor = false;
			this.BtnConsultarImportador.Click += new System.EventHandler(this.BtnConsultarImportador_Click);
			// 
			// BtnShowProductos
			// 
			this.BtnShowProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnShowProductos.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnShowProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnShowProductos.Location = new System.Drawing.Point(63, 544);
			this.BtnShowProductos.Name = "BtnShowProductos";
			this.BtnShowProductos.Size = new System.Drawing.Size(470, 127);
			this.BtnShowProductos.TabIndex = 15;
			this.BtnShowProductos.Text = "Ver los productos mas importados/exportados";
			this.BtnShowProductos.UseVisualStyleBackColor = false;
			this.BtnShowProductos.Click += new System.EventHandler(this.BtnShowProductos_Click);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.ClientSize = new System.Drawing.Size(593, 708);
			this.ControlBox = false;
			this.Controls.Add(this.BtnShowProductos);
			this.Controls.Add(this.BtnConsultarImportador);
			this.Controls.Add(this.BtnPedimentoPorAduana);
			this.Controls.Add(this.BtnConsultarPorProducto);
			this.Controls.Add(this.BtnPedimentosPorFecha);
			this.Controls.Add(this.BtnConsultarPedimento);
			this.Controls.Add(this.BtnHacerPedimento);
			this.Controls.Add(this.BtnRegistros);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPrincipal";
			this.Text = "Menú";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnRegistros;
		private System.Windows.Forms.Button BtnHacerPedimento;
		private System.Windows.Forms.Button BtnConsultarPedimento;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarAplicacionToolStripMenuItem;
		private System.Windows.Forms.Button BtnPedimentosPorFecha;
		private System.Windows.Forms.Button BtnConsultarPorProducto;
		private System.Windows.Forms.Button BtnPedimentoPorAduana;
		private System.Windows.Forms.Button BtnConsultarImportador;
		private System.Windows.Forms.Button BtnShowProductos;
	}
}
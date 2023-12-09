namespace Proyecto_TBD
{
	partial class FrmConsultarPedimento
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtNoPedimento = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblPedimento = new System.Windows.Forms.Label();
			this.lblAgente = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblImportador = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblAduana = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.BtnConsultar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.productosEnPedimento = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.BtnDescargarPedimento = new System.Windows.Forms.Button();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productosEnPedimento)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label1.Location = new System.Drawing.Point(133, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(840, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Introduce cualquier dato del pedimento que desees consultar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label2.Location = new System.Drawing.Point(174, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 41);
			this.label2.TabIndex = 2;
			this.label2.Text = "No. de Pedimento";
			// 
			// txtNoPedimento
			// 
			this.txtNoPedimento.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNoPedimento.Location = new System.Drawing.Point(395, 108);
			this.txtNoPedimento.Name = "txtNoPedimento";
			this.txtNoPedimento.Size = new System.Drawing.Size(245, 32);
			this.txtNoPedimento.TabIndex = 14;
			this.txtNoPedimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoPedimento_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label3.Location = new System.Drawing.Point(12, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 36);
			this.label3.TabIndex = 15;
			this.label3.Text = "No. de Pedimento";
			// 
			// lblPedimento
			// 
			this.lblPedimento.AutoEllipsis = true;
			this.lblPedimento.AutoSize = true;
			this.lblPedimento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblPedimento.Location = new System.Drawing.Point(191, 200);
			this.lblPedimento.Name = "lblPedimento";
			this.lblPedimento.Size = new System.Drawing.Size(39, 36);
			this.lblPedimento.TabIndex = 16;
			this.lblPedimento.Text = "---";
			// 
			// lblAgente
			// 
			this.lblAgente.AutoEllipsis = true;
			this.lblAgente.AutoSize = true;
			this.lblAgente.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblAgente.Location = new System.Drawing.Point(491, 200);
			this.lblAgente.Name = "lblAgente";
			this.lblAgente.Size = new System.Drawing.Size(39, 36);
			this.lblAgente.TabIndex = 18;
			this.lblAgente.Text = "---";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label5.Location = new System.Drawing.Point(407, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 36);
			this.label5.TabIndex = 17;
			this.label5.Text = "Agente";
			// 
			// lblImportador
			// 
			this.lblImportador.AutoEllipsis = true;
			this.lblImportador.AutoSize = true;
			this.lblImportador.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImportador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblImportador.Location = new System.Drawing.Point(934, 200);
			this.lblImportador.Name = "lblImportador";
			this.lblImportador.Size = new System.Drawing.Size(39, 36);
			this.lblImportador.TabIndex = 20;
			this.lblImportador.Text = "---";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label6.Location = new System.Drawing.Point(801, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 36);
			this.label6.TabIndex = 19;
			this.label6.Text = "Importador";
			// 
			// lblAduana
			// 
			this.lblAduana.AutoEllipsis = true;
			this.lblAduana.AutoSize = true;
			this.lblAduana.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAduana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblAduana.Location = new System.Drawing.Point(397, 268);
			this.lblAduana.Name = "lblAduana";
			this.lblAduana.Size = new System.Drawing.Size(39, 36);
			this.lblAduana.TabIndex = 22;
			this.lblAduana.Text = "---";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label7.Location = new System.Drawing.Point(156, 268);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(227, 36);
			this.label7.TabIndex = 21;
			this.label7.Text = "Aduana por donde pasó";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoEllipsis = true;
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblFecha.Location = new System.Drawing.Point(750, 268);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(39, 36);
			this.lblFecha.TabIndex = 24;
			this.lblFecha.Text = "---";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label8.Location = new System.Drawing.Point(662, 268);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 36);
			this.label8.TabIndex = 23;
			this.label8.Text = "Fecha";
			// 
			// BtnConsultar
			// 
			this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnConsultar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnConsultar.Location = new System.Drawing.Point(693, 102);
			this.BtnConsultar.Name = "BtnConsultar";
			this.BtnConsultar.Size = new System.Drawing.Size(334, 41);
			this.BtnConsultar.TabIndex = 25;
			this.BtnConsultar.Text = "Buscar pedimento";
			this.BtnConsultar.UseVisualStyleBackColor = false;
			this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label4.Location = new System.Drawing.Point(374, 351);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(296, 36);
			this.label4.TabIndex = 26;
			this.label4.Text = "Lista de Articulos del pedimento";
			// 
			// productosEnPedimento
			// 
			this.productosEnPedimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.productosEnPedimento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.productosEnPedimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productosEnPedimento.Location = new System.Drawing.Point(120, 390);
			this.productosEnPedimento.Name = "productosEnPedimento";
			this.productosEnPedimento.ReadOnly = true;
			this.productosEnPedimento.RowHeadersWidth = 51;
			this.productosEnPedimento.RowTemplate.Height = 24;
			this.productosEnPedimento.Size = new System.Drawing.Size(797, 209);
			this.productosEnPedimento.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label9.Location = new System.Drawing.Point(491, 612);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(301, 36);
			this.label9.TabIndex = 28;
			this.label9.Text = "Total (con un impuesto del 20%):";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoEllipsis = true;
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblTotal.Location = new System.Drawing.Point(815, 612);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(39, 36);
			this.lblTotal.TabIndex = 29;
			this.lblTotal.Text = "---";
			// 
			// BtnDescargarPedimento
			// 
			this.BtnDescargarPedimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnDescargarPedimento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDescargarPedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnDescargarPedimento.Location = new System.Drawing.Point(151, 656);
			this.BtnDescargarPedimento.Name = "BtnDescargarPedimento";
			this.BtnDescargarPedimento.Size = new System.Drawing.Size(347, 41);
			this.BtnDescargarPedimento.TabIndex = 30;
			this.BtnDescargarPedimento.Text = "Descargar Pedimento";
			this.BtnDescargarPedimento.UseVisualStyleBackColor = false;
			this.BtnDescargarPedimento.Visible = false;
			this.BtnDescargarPedimento.Click += new System.EventHandler(this.BtnDescargarPedimento_Click);
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnLimpiar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnLimpiar.Location = new System.Drawing.Point(940, 471);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(178, 41);
			this.BtnLimpiar.TabIndex = 31;
			this.BtnLimpiar.Text = "Limpiar";
			this.BtnLimpiar.UseVisualStyleBackColor = false;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// FrmConsultarPedimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.ClientSize = new System.Drawing.Size(1150, 709);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.BtnDescargarPedimento);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.productosEnPedimento);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BtnConsultar);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblAduana);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblImportador);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblAgente);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblPedimento);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNoPedimento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmConsultarPedimento";
			this.Text = "FrmConsultarPedimento";
			((System.ComponentModel.ISupportInitialize)(this.productosEnPedimento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNoPedimento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblPedimento;
		private System.Windows.Forms.Label lblAgente;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblImportador;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblAduana;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button BtnConsultar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView productosEnPedimento;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button BtnDescargarPedimento;
		private System.Windows.Forms.Button BtnLimpiar;
	}
}
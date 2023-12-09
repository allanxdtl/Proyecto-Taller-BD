namespace Proyecto_TBD
{
	partial class FrmConsultarPorProducto
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
			this.cmbProductos = new System.Windows.Forms.ComboBox();
			this.pedimentos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pedimentos)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbProductos
			// 
			this.cmbProductos.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProductos.FormattingEnabled = true;
			this.cmbProductos.Location = new System.Drawing.Point(380, 108);
			this.cmbProductos.Name = "cmbProductos";
			this.cmbProductos.Size = new System.Drawing.Size(387, 49);
			this.cmbProductos.TabIndex = 0;
			this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
			// 
			// pedimentos
			// 
			this.pedimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.pedimentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.pedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pedimentos.Location = new System.Drawing.Point(145, 178);
			this.pedimentos.Name = "pedimentos";
			this.pedimentos.RowHeadersWidth = 51;
			this.pedimentos.RowTemplate.Height = 24;
			this.pedimentos.Size = new System.Drawing.Size(870, 245);
			this.pedimentos.TabIndex = 1;
			this.pedimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.label1.Location = new System.Drawing.Point(55, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1032, 50);
			this.label1.TabIndex = 2;
			this.label1.Text = "Seleccionar el producto que quieres consultar en todos los pedimentos existentes";
			// 
			// FrmConsultarPorProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.ClientSize = new System.Drawing.Size(1198, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pedimentos);
			this.Controls.Add(this.cmbProductos);
			this.Name = "FrmConsultarPorProducto";
			this.Text = "Consultar pedimento por producto";
			((System.ComponentModel.ISupportInitialize)(this.pedimentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbProductos;
		private System.Windows.Forms.DataGridView pedimentos;
		private System.Windows.Forms.Label label1;
	}
}
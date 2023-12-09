namespace Proyecto_TBD
{
	partial class FrmMakePedimento
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbAgentes = new System.Windows.Forms.ComboBox();
			this.cmbImport = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbCiudades = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.fecha = new System.Windows.Forms.DateTimePicker();
			this.cmbProductos = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCantidadArticulo = new System.Windows.Forms.TextBox();
			this.BtnAddProducto = new System.Windows.Forms.Button();
			this.productosEnPedimento = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label8 = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.BtnMakePedimento = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productosEnPedimento)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label1.Location = new System.Drawing.Point(244, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(645, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Rellena los datos necesarios para el pedimento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 41);
			this.label2.TabIndex = 2;
			this.label2.Text = "Agente Aduanal";
			// 
			// cmbAgentes
			// 
			this.cmbAgentes.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAgentes.FormattingEnabled = true;
			this.cmbAgentes.Location = new System.Drawing.Point(216, 92);
			this.cmbAgentes.Name = "cmbAgentes";
			this.cmbAgentes.Size = new System.Drawing.Size(244, 31);
			this.cmbAgentes.TabIndex = 3;
			// 
			// cmbImport
			// 
			this.cmbImport.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbImport.FormattingEnabled = true;
			this.cmbImport.Location = new System.Drawing.Point(740, 92);
			this.cmbImport.Name = "cmbImport";
			this.cmbImport.Size = new System.Drawing.Size(244, 31);
			this.cmbImport.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label3.Location = new System.Drawing.Point(464, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 41);
			this.label3.TabIndex = 4;
			this.label3.Text = "Importador/Exportador";
			// 
			// cmbCiudades
			// 
			this.cmbCiudades.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCiudades.FormattingEnabled = true;
			this.cmbCiudades.Location = new System.Drawing.Point(479, 149);
			this.cmbCiudades.Name = "cmbCiudades";
			this.cmbCiudades.Size = new System.Drawing.Size(244, 31);
			this.cmbCiudades.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label4.Location = new System.Drawing.Point(13, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(426, 41);
			this.label4.TabIndex = 6;
			this.label4.Text = "Aduana por donde pasara el pedimento";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label5.Location = new System.Drawing.Point(757, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(195, 41);
			this.label5.TabIndex = 8;
			this.label5.Text = "Fecha de emision";
			// 
			// fecha
			// 
			this.fecha.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fecha.Location = new System.Drawing.Point(968, 153);
			this.fecha.Name = "fecha";
			this.fecha.Size = new System.Drawing.Size(130, 32);
			this.fecha.TabIndex = 9;
			// 
			// cmbProductos
			// 
			this.cmbProductos.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProductos.FormattingEnabled = true;
			this.cmbProductos.Location = new System.Drawing.Point(267, 243);
			this.cmbProductos.Name = "cmbProductos";
			this.cmbProductos.Size = new System.Drawing.Size(244, 31);
			this.cmbProductos.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label6.Location = new System.Drawing.Point(150, 243);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 41);
			this.label6.TabIndex = 10;
			this.label6.Text = "Producto";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label7.Location = new System.Drawing.Point(539, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 41);
			this.label7.TabIndex = 12;
			this.label7.Text = "Cantidad";
			// 
			// txtCantidadArticulo
			// 
			this.txtCantidadArticulo.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidadArticulo.Location = new System.Drawing.Point(656, 243);
			this.txtCantidadArticulo.Name = "txtCantidadArticulo";
			this.txtCantidadArticulo.Size = new System.Drawing.Size(67, 32);
			this.txtCantidadArticulo.TabIndex = 13;
			// 
			// BtnAddProducto
			// 
			this.BtnAddProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnAddProducto.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAddProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnAddProducto.Location = new System.Drawing.Point(764, 236);
			this.BtnAddProducto.Name = "BtnAddProducto";
			this.BtnAddProducto.Size = new System.Drawing.Size(334, 41);
			this.BtnAddProducto.TabIndex = 14;
			this.BtnAddProducto.Text = "Agregar al pedimento";
			this.BtnAddProducto.UseVisualStyleBackColor = false;
			this.BtnAddProducto.Click += new System.EventHandler(this.BtnAddProducto_Click);
			// 
			// productosEnPedimento
			// 
			this.productosEnPedimento.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(149)))), ((int)(((byte)(165)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(149)))), ((int)(((byte)(165)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.productosEnPedimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.productosEnPedimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.productosEnPedimento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.productosEnPedimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.productosEnPedimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productosEnPedimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(158)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(158)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.productosEnPedimento.DefaultCellStyle = dataGridViewCellStyle3;
			this.productosEnPedimento.EnableHeadersVisualStyles = false;
			this.productosEnPedimento.Location = new System.Drawing.Point(187, 301);
			this.productosEnPedimento.Name = "productosEnPedimento";
			this.productosEnPedimento.ReadOnly = true;
			this.productosEnPedimento.RowHeadersVisible = false;
			this.productosEnPedimento.RowHeadersWidth = 51;
			this.productosEnPedimento.RowTemplate.Height = 24;
			this.productosEnPedimento.Size = new System.Drawing.Size(797, 209);
			this.productosEnPedimento.TabIndex = 15;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "IDArticulo";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 141;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 121;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Precio";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 103;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Cantidad";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 128;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Subtotal";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 124;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label8.Location = new System.Drawing.Point(733, 528);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 41);
			this.label8.TabIndex = 16;
			this.label8.Text = "Subtotal:";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.lblSubtotal.Location = new System.Drawing.Point(841, 528);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(30, 41);
			this.lblSubtotal.TabIndex = 17;
			this.lblSubtotal.Text = "0";
			// 
			// BtnMakePedimento
			// 
			this.BtnMakePedimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnMakePedimento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnMakePedimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnMakePedimento.Location = new System.Drawing.Point(402, 564);
			this.BtnMakePedimento.Name = "BtnMakePedimento";
			this.BtnMakePedimento.Size = new System.Drawing.Size(334, 49);
			this.BtnMakePedimento.TabIndex = 18;
			this.BtnMakePedimento.Text = "Hacer pedimento";
			this.BtnMakePedimento.UseVisualStyleBackColor = false;
			this.BtnMakePedimento.Click += new System.EventHandler(this.BtnMakePedimento_Click);
			// 
			// FrmMakePedimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.ClientSize = new System.Drawing.Size(1146, 631);
			this.Controls.Add(this.BtnMakePedimento);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.productosEnPedimento);
			this.Controls.Add(this.BtnAddProducto);
			this.Controls.Add(this.txtCantidadArticulo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbProductos);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.fecha);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbCiudades);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbImport);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbAgentes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmMakePedimento";
			this.Text = "Hacer pedimento";
			((System.ComponentModel.ISupportInitialize)(this.productosEnPedimento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbAgentes;
		private System.Windows.Forms.ComboBox cmbImport;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbCiudades;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker fecha;
		private System.Windows.Forms.ComboBox cmbProductos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCantidadArticulo;
		private System.Windows.Forms.Button BtnAddProducto;
		private System.Windows.Forms.DataGridView productosEnPedimento;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Button BtnMakePedimento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}
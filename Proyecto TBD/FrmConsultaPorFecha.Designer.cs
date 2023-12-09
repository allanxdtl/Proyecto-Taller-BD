namespace Proyecto_TBD
{
	partial class FrmConsultaPorFecha
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
			this.fecha = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pedimentos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pedimentos)).BeginInit();
			this.SuspendLayout();
			// 
			// fecha
			// 
			this.fecha.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fecha.Location = new System.Drawing.Point(374, 108);
			this.fecha.Name = "fecha";
			this.fecha.Size = new System.Drawing.Size(130, 32);
			this.fecha.TabIndex = 11;
			this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label5.Location = new System.Drawing.Point(255, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 41);
			this.label5.TabIndex = 10;
			this.label5.Text = "Fecha";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label1.Location = new System.Drawing.Point(183, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(410, 50);
			this.label1.TabIndex = 12;
			this.label1.Text = "Ingresa la fecha que te interese";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label2.Location = new System.Drawing.Point(35, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(721, 41);
			this.label2.TabIndex = 13;
			this.label2.Text = "Despues selecciona el registro que desees para ver todos los detalles";
			// 
			// pedimentos
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(149)))), ((int)(((byte)(165)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.pedimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.pedimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.pedimentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.pedimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.pedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(158)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.pedimentos.DefaultCellStyle = dataGridViewCellStyle3;
			this.pedimentos.EnableHeadersVisualStyles = false;
			this.pedimentos.Location = new System.Drawing.Point(151, 203);
			this.pedimentos.Name = "pedimentos";
			this.pedimentos.ReadOnly = true;
			this.pedimentos.RowHeadersVisible = false;
			this.pedimentos.RowHeadersWidth = 51;
			this.pedimentos.RowTemplate.Height = 24;
			this.pedimentos.Size = new System.Drawing.Size(497, 198);
			this.pedimentos.TabIndex = 15;
			this.pedimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedimentos_CellClick);
			// 
			// FrmConsultaPorFecha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.ClientSize = new System.Drawing.Size(802, 420);
			this.Controls.Add(this.pedimentos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fecha);
			this.Controls.Add(this.label5);
			this.Name = "FrmConsultaPorFecha";
			this.Text = "Consultar por fecha";
			((System.ComponentModel.ISupportInitialize)(this.pedimentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker fecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView pedimentos;
	}
}
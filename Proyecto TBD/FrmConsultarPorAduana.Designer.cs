namespace Proyecto_TBD
{
	partial class FrmConsultarPorAduana
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
			this.cmbAduanas = new System.Windows.Forms.ComboBox();
			this.pedimentos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pedimentos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.label1.Location = new System.Drawing.Point(49, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1009, 50);
			this.label1.TabIndex = 5;
			this.label1.Text = "Seleccionar la aduana que quieres consultar en todos los pedimentos existentes";
			// 
			// cmbAduanas
			// 
			this.cmbAduanas.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAduanas.FormattingEnabled = true;
			this.cmbAduanas.Location = new System.Drawing.Point(326, 108);
			this.cmbAduanas.Name = "cmbAduanas";
			this.cmbAduanas.Size = new System.Drawing.Size(387, 49);
			this.cmbAduanas.TabIndex = 3;
			this.cmbAduanas.SelectedIndexChanged += new System.EventHandler(this.cmbAduanas_SelectedIndexChanged);
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
			this.pedimentos.Location = new System.Drawing.Point(168, 195);
			this.pedimentos.Name = "pedimentos";
			this.pedimentos.ReadOnly = true;
			this.pedimentos.RowHeadersVisible = false;
			this.pedimentos.RowHeadersWidth = 51;
			this.pedimentos.RowTemplate.Height = 24;
			this.pedimentos.Size = new System.Drawing.Size(717, 198);
			this.pedimentos.TabIndex = 16;
			this.pedimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedimentos_CellClick);
			// 
			// FrmConsultarPorAduana
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.ClientSize = new System.Drawing.Size(1092, 450);
			this.Controls.Add(this.pedimentos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbAduanas);
			this.Name = "FrmConsultarPorAduana";
			this.Text = "Consultar pedimento por aduana";
			((System.ComponentModel.ISupportInitialize)(this.pedimentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbAduanas;
		private System.Windows.Forms.DataGridView pedimentos;
	}
}
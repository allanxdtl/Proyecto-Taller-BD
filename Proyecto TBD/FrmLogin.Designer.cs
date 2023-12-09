namespace Proyecto_TBD
{
	partial class FrmLogin
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.BtnLog = new System.Windows.Forms.Button();
			this.BtnClose = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label1.Location = new System.Drawing.Point(181, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label2.Location = new System.Drawing.Point(92, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 41);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
			this.label3.Location = new System.Drawing.Point(55, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 41);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña";
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(208, 81);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(247, 50);
			this.txtUser.TabIndex = 3;
			this.txtUser.Text = "allancito";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(208, 134);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(247, 50);
			this.txtPassword.TabIndex = 4;
			this.txtPassword.Text = "nomanches";
			// 
			// BtnLog
			// 
			this.BtnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnLog.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnLog.Location = new System.Drawing.Point(166, 250);
			this.BtnLog.Name = "BtnLog";
			this.BtnLog.Size = new System.Drawing.Size(209, 57);
			this.BtnLog.TabIndex = 5;
			this.BtnLog.Text = "Iniciar Sesion";
			this.BtnLog.UseVisualStyleBackColor = false;
			this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
			// 
			// BtnClose
			// 
			this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
			this.BtnClose.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.BtnClose.Location = new System.Drawing.Point(300, 356);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(240, 44);
			this.BtnClose.TabIndex = 6;
			this.BtnClose.Text = "Cerrar Aplicacion";
			this.BtnClose.UseVisualStyleBackColor = false;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Location = new System.Drawing.Point(254, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(201, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Registrar nuevo usuario";
			this.label4.Visible = false;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
			this.ClientSize = new System.Drawing.Size(551, 413);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.BtnLog);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmLogin";
			this.Text = "Iniciar Sesión";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button BtnLog;
		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.Label label4;
	}
}


namespace ProDATA
{
    partial class frmLogin
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
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.Txtbuser = new System.Windows.Forms.TextBox();
            this.Txtbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(21, 120);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(107, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(18, 49);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(43, 13);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "Usuario";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(15, 79);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(61, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Contraseña";
            // 
            // Txtbuser
            // 
            this.Txtbuser.Location = new System.Drawing.Point(82, 50);
            this.Txtbuser.Name = "Txtbuser";
            this.Txtbuser.Size = new System.Drawing.Size(100, 20);
            this.Txtbuser.TabIndex = 4;
            // 
            // Txtbpassword
            // 
            this.Txtbpassword.Location = new System.Drawing.Point(82, 76);
            this.Txtbpassword.Name = "Txtbpassword";
            this.Txtbpassword.PasswordChar = '*';
            this.Txtbpassword.Size = new System.Drawing.Size(100, 20);
            this.Txtbpassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acceso a sistema";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtbpassword);
            this.Controls.Add(this.Txtbuser);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcceder);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox Txtbuser;
        private System.Windows.Forms.TextBox Txtbpassword;
        private System.Windows.Forms.Label label1;
    }
}


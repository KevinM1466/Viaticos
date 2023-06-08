namespace CalculoViaticos.FORMULARIOS
{
    partial class frmRecuperarContra
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
            this.tctCorreo = new System.Windows.Forms.TextBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico";
            // 
            // tctCorreo
            // 
            this.tctCorreo.Location = new System.Drawing.Point(284, 115);
            this.tctCorreo.Name = "tctCorreo";
            this.tctCorreo.Size = new System.Drawing.Size(310, 22);
            this.tctCorreo.TabIndex = 1;
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(382, 169);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(115, 41);
            this.btnEnviarCorreo.TabIndex = 2;
            this.btnEnviarCorreo.Text = "Enviar";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(410, 242);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(59, 16);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Mensaje";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CalculoViaticos.Properties.Resources.TecnasaLogo;
            this.pictureBox3.Location = new System.Drawing.Point(40, 66);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(234, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // frmRecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(644, 368);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.tctCorreo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarContra";
            this.Text = "frmRecuperarContra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tctCorreo;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
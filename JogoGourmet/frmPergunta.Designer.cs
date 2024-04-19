namespace JogoGourmet
{
    partial class frmPergunta
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnYES = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(12, 24);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(203, 15);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Pense em um prato que você gosta.";
            // 
            // btnYES
            // 
            this.btnYES.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYES.Location = new System.Drawing.Point(61, 79);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(96, 26);
            this.btnYES.TabIndex = 3;
            this.btnYES.Text = "&Yes";
            this.btnYES.UseVisualStyleBackColor = true;
            // 
            // btnNO
            // 
            this.btnNO.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNO.Location = new System.Drawing.Point(173, 79);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(96, 26);
            this.btnNO.TabIndex = 4;
            this.btnNO.Text = "&No";
            this.btnNO.UseVisualStyleBackColor = true;
            // 
            // frmPergunta
            // 
            this.ClientSize = new System.Drawing.Size(299, 114);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPergunta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Label lblMensagem;
    }
}
namespace Gafanhoto
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnComer = new System.Windows.Forms.Button();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btnComer
            // 
            this.btnComer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComer.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnComer.Location = new System.Drawing.Point(167, 84);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(138, 37);
            this.btnComer.TabIndex = 0;
            this.btnComer.Text = "&COMER";
            this.btnComer.UseVisualStyleBackColor = true;
            this.btnComer.Click += new System.EventHandler(this.btnComer_Click);
            // 
            // txtOpen
            // 
            this.txtOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOpen.Location = new System.Drawing.Point(28, 41);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(398, 22);
            this.txtOpen.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfo.Location = new System.Drawing.Point(27, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(130, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "&SELECIONE O ARQUIVO";
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnOpen.Location = new System.Drawing.Point(432, 41);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(38, 22);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "...";
            this.btnOpen.UseCompatibleTextRendering = true;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(495, 137);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.btnComer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAFANHOTO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOpen;
    }
}


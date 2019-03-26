namespace ProjetoPetz
{
    partial class UserEmitirR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUtiliDois = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.mskDiaBuscado = new System.Windows.Forms.MaskedTextBox();
            this.btnRendimento = new System.Windows.Forms.Button();
            this.btnBucsarPD = new System.Windows.Forms.Button();
            this.lblAlgum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtiliDois)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtiliDois
            // 
            this.dgvUtiliDois.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUtiliDois.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtiliDois.Location = new System.Drawing.Point(379, 48);
            this.dgvUtiliDois.Name = "dgvUtiliDois";
            this.dgvUtiliDois.Size = new System.Drawing.Size(365, 365);
            this.dgvUtiliDois.TabIndex = 3;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMsg.Location = new System.Drawing.Point(3, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(528, 21);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Informe a data desejada para ver o movimento do: (Dia/Mês/Ano)";
            // 
            // mskDiaBuscado
            // 
            this.mskDiaBuscado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDiaBuscado.Location = new System.Drawing.Point(576, 13);
            this.mskDiaBuscado.Mask = "00/00/0000";
            this.mskDiaBuscado.Name = "mskDiaBuscado";
            this.mskDiaBuscado.Size = new System.Drawing.Size(100, 22);
            this.mskDiaBuscado.TabIndex = 2;
            this.mskDiaBuscado.ValidatingType = typeof(System.DateTime);
            // 
            // btnRendimento
            // 
            this.btnRendimento.BackColor = System.Drawing.Color.Transparent;
            this.btnRendimento.FlatAppearance.BorderSize = 0;
            this.btnRendimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRendimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendimento.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRendimento.Location = new System.Drawing.Point(25, 253);
            this.btnRendimento.Name = "btnRendimento";
            this.btnRendimento.Size = new System.Drawing.Size(213, 30);
            this.btnRendimento.TabIndex = 4;
            this.btnRendimento.Text = "Rendimento do dia";
            this.btnRendimento.UseVisualStyleBackColor = false;
            this.btnRendimento.Click += new System.EventHandler(this.btnRendimento_Click);
            // 
            // btnBucsarPD
            // 
            this.btnBucsarPD.BackColor = System.Drawing.Color.Transparent;
            this.btnBucsarPD.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnBucsarPD.FlatAppearance.BorderSize = 0;
            this.btnBucsarPD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBucsarPD.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucsarPD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBucsarPD.Location = new System.Drawing.Point(25, 142);
            this.btnBucsarPD.Name = "btnBucsarPD";
            this.btnBucsarPD.Size = new System.Drawing.Size(250, 33);
            this.btnBucsarPD.TabIndex = 5;
            this.btnBucsarPD.Text = "Informações sobre o dono e pet";
            this.btnBucsarPD.UseVisualStyleBackColor = false;
            this.btnBucsarPD.Click += new System.EventHandler(this.btnBucsarPD_Click);
            // 
            // lblAlgum
            // 
            this.lblAlgum.AutoSize = true;
            this.lblAlgum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAlgum.Location = new System.Drawing.Point(261, 48);
            this.lblAlgum.Name = "lblAlgum";
            this.lblAlgum.Size = new System.Drawing.Size(0, 16);
            this.lblAlgum.TabIndex = 6;
            // 
            // UserEmitirR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lblAlgum);
            this.Controls.Add(this.btnBucsarPD);
            this.Controls.Add(this.btnRendimento);
            this.Controls.Add(this.dgvUtiliDois);
            this.Controls.Add(this.mskDiaBuscado);
            this.Controls.Add(this.lblMsg);
            this.Name = "UserEmitirR";
            this.Size = new System.Drawing.Size(761, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtiliDois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtiliDois;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.MaskedTextBox mskDiaBuscado;
        private System.Windows.Forms.Button btnRendimento;
        private System.Windows.Forms.Button btnBucsarPD;
        private System.Windows.Forms.Label lblAlgum;
    }
}

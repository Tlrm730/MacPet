namespace ProjetoPetz
{
    partial class UserExibirDisp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserExibirDisp));
            this.lblVeterinarios = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVeterinarios
            // 
            this.lblVeterinarios.AutoSize = true;
            this.lblVeterinarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinarios.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVeterinarios.Location = new System.Drawing.Point(183, 36);
            this.lblVeterinarios.Name = "lblVeterinarios";
            this.lblVeterinarios.Size = new System.Drawing.Size(219, 25);
            this.lblVeterinarios.TabIndex = 2;
            this.lblVeterinarios.Text = "Serviços agendados";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(626, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar os serviços";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVeterinarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinarios.Location = new System.Drawing.Point(55, 87);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.Size = new System.Drawing.Size(498, 236);
            this.dgvVeterinarios.TabIndex = 0;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(639, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(135, 90);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 4;
            this.pcbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(663, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "MecPet";
            // 
            // UserExibirDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVeterinarios);
            this.Controls.Add(this.dgvVeterinarios);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "UserExibirDisp";
            this.Size = new System.Drawing.Size(836, 378);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVeterinarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label label1;
    }
}

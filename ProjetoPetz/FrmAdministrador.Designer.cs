namespace ProjetoPetz
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmitirR = new System.Windows.Forms.Button();
            this.btnManterF = new System.Windows.Forms.Button();
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.userExecucao1 = new ProjetoPetz.UserExecucao();
            this.userFuncionario1 = new ProjetoPetz.UserFuncionario();
            this.userEmitirR1 = new ProjetoPetz.UserEmitirR();
            this.userTelaAdm1 = new ProjetoPetz.UserTelaAdm();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnEmitirR);
            this.pnlMenu.Controls.Add(this.btnManterF);
            this.pnlMenu.Location = new System.Drawing.Point(0, -8);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(165, 526);
            this.pnlMenu.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "MecPet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(25, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastro de Execução";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmitirR
            // 
            this.btnEmitirR.FlatAppearance.BorderSize = 0;
            this.btnEmitirR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirR.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEmitirR.Location = new System.Drawing.Point(25, 159);
            this.btnEmitirR.Name = "btnEmitirR";
            this.btnEmitirR.Size = new System.Drawing.Size(112, 49);
            this.btnEmitirR.TabIndex = 2;
            this.btnEmitirR.Text = "Emitir um relatório";
            this.btnEmitirR.UseVisualStyleBackColor = true;
            this.btnEmitirR.Click += new System.EventHandler(this.btnEmitirR_Click);
            // 
            // btnManterF
            // 
            this.btnManterF.FlatAppearance.BorderSize = 0;
            this.btnManterF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterF.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnManterF.Location = new System.Drawing.Point(25, 263);
            this.btnManterF.Name = "btnManterF";
            this.btnManterF.Size = new System.Drawing.Size(112, 49);
            this.btnManterF.TabIndex = 1;
            this.btnManterF.Text = "Cadastrar funcionários";
            this.btnManterF.UseVisualStyleBackColor = true;
            this.btnManterF.Click += new System.EventHandler(this.btnManterF_Click);
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFerramentas.Controls.Add(this.btnMinimizar);
            this.pnlFerramentas.Controls.Add(this.btnFechar);
            this.pnlFerramentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFerramentas.Location = new System.Drawing.Point(164, -4);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Size = new System.Drawing.Size(837, 31);
            this.pnlFerramentas.TabIndex = 19;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(770, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 23);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(802, 4);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(31, 22);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // userExecucao1
            // 
            this.userExecucao1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userExecucao1.Location = new System.Drawing.Point(164, 28);
            this.userExecucao1.Name = "userExecucao1";
            this.userExecucao1.Size = new System.Drawing.Size(834, 486);
            this.userExecucao1.TabIndex = 20;
            // 
            // userFuncionario1
            // 
            this.userFuncionario1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userFuncionario1.Location = new System.Drawing.Point(165, 27);
            this.userFuncionario1.Margin = new System.Windows.Forms.Padding(2);
            this.userFuncionario1.Name = "userFuncionario1";
            this.userFuncionario1.Size = new System.Drawing.Size(836, 480);
            this.userFuncionario1.TabIndex = 21;
            // 
            // userEmitirR1
            // 
            this.userEmitirR1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userEmitirR1.Location = new System.Drawing.Point(164, 27);
            this.userEmitirR1.Name = "userEmitirR1";
            this.userEmitirR1.Size = new System.Drawing.Size(834, 491);
            this.userEmitirR1.TabIndex = 22;
            // 
            // userTelaAdm1
            // 
            this.userTelaAdm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTelaAdm1.Location = new System.Drawing.Point(164, 28);
            this.userTelaAdm1.Margin = new System.Windows.Forms.Padding(2);
            this.userTelaAdm1.Name = "userTelaAdm1";
            this.userTelaAdm1.Size = new System.Drawing.Size(836, 480);
            this.userTelaAdm1.TabIndex = 23;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.userTelaAdm1);
            this.Controls.Add(this.userEmitirR1);
            this.Controls.Add(this.userFuncionario1);
            this.Controls.Add(this.userExecucao1);
            this.Controls.Add(this.pnlFerramentas);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFerramentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnEmitirR;
        private System.Windows.Forms.Button btnManterF;
        private System.Windows.Forms.Panel pnlFerramentas;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private UserExecucao userExecucao1;
        private UserFuncionario userFuncionario1;
        private UserEmitirR userEmitirR1;
        private UserTelaAdm userTelaAdm1;
    }
}
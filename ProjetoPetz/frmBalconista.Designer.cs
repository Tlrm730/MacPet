namespace ProjetoPetz
{
    partial class frmBalconista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBalconista));
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExibirD = new System.Windows.Forms.Button();
            this.btnManterA = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnManterC = new System.Windows.Forms.Button();
            this.btnManterS = new System.Windows.Forms.Button();
            this.btnAgendarS = new System.Windows.Forms.Button();
            this.userTelaInicial1 = new ProjetoPetz.UserTelaInicial();
            this.userExibirDisp1 = new ProjetoPetz.UserExibirDisp();
            this.userManterS1 = new ProjetoPetz.UserManterS();
            this.userManterA1 = new ProjetoPetz.UserManterA();
            this.userCliente1 = new ProjetoPetz.UserCliente();
            this.userAgendarS1 = new ProjetoPetz.UserAgendarS();
            this.pnlFerramentas.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFerramentas.Controls.Add(this.btnMinimizar);
            this.pnlFerramentas.Controls.Add(this.btnFechar);
            this.pnlFerramentas.Location = new System.Drawing.Point(164, 0);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Size = new System.Drawing.Size(837, 37);
            this.pnlFerramentas.TabIndex = 16;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(764, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 26);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.button1_Click);
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
            this.btnFechar.Size = new System.Drawing.Size(30, 27);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnExibirD);
            this.pnlMenu.Controls.Add(this.btnManterA);
            this.pnlMenu.Controls.Add(this.pcbLogo);
            this.pnlMenu.Controls.Add(this.btnManterC);
            this.pnlMenu.Controls.Add(this.btnManterS);
            this.pnlMenu.Controls.Add(this.btnAgendarS);
            this.pnlMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(165, 525);
            this.pnlMenu.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "MecPet";
            // 
            // btnExibirD
            // 
            this.btnExibirD.FlatAppearance.BorderSize = 0;
            this.btnExibirD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirD.ForeColor = System.Drawing.Color.Black;
            this.btnExibirD.Location = new System.Drawing.Point(13, 401);
            this.btnExibirD.Name = "btnExibirD";
            this.btnExibirD.Size = new System.Drawing.Size(135, 49);
            this.btnExibirD.TabIndex = 6;
            this.btnExibirD.Text = "Exibir disponibilidade";
            this.btnExibirD.UseVisualStyleBackColor = true;
            this.btnExibirD.Click += new System.EventHandler(this.btnExibirD_Click);
            // 
            // btnManterA
            // 
            this.btnManterA.FlatAppearance.BorderSize = 0;
            this.btnManterA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterA.ForeColor = System.Drawing.Color.Black;
            this.btnManterA.Location = new System.Drawing.Point(24, 279);
            this.btnManterA.Name = "btnManterA";
            this.btnManterA.Size = new System.Drawing.Size(112, 49);
            this.btnManterA.TabIndex = 5;
            this.btnManterA.Text = "Cadastro de Animais";
            this.btnManterA.UseVisualStyleBackColor = true;
            this.btnManterA.Click += new System.EventHandler(this.button6_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(15, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(135, 90);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 3;
            this.pcbLogo.TabStop = false;
            // 
            // btnManterC
            // 
            this.btnManterC.FlatAppearance.BorderSize = 0;
            this.btnManterC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterC.ForeColor = System.Drawing.Color.Black;
            this.btnManterC.Location = new System.Drawing.Point(24, 218);
            this.btnManterC.Name = "btnManterC";
            this.btnManterC.Size = new System.Drawing.Size(112, 49);
            this.btnManterC.TabIndex = 2;
            this.btnManterC.Text = "Cadastro de clientes";
            this.btnManterC.UseVisualStyleBackColor = true;
            this.btnManterC.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnManterS
            // 
            this.btnManterS.FlatAppearance.BorderSize = 0;
            this.btnManterS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManterS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManterS.ForeColor = System.Drawing.Color.Black;
            this.btnManterS.Location = new System.Drawing.Point(15, 340);
            this.btnManterS.Name = "btnManterS";
            this.btnManterS.Size = new System.Drawing.Size(130, 49);
            this.btnManterS.TabIndex = 1;
            this.btnManterS.Text = "Agendamento de serviço";
            this.btnManterS.UseVisualStyleBackColor = true;
            this.btnManterS.Click += new System.EventHandler(this.btnManterS_Click);
            // 
            // btnAgendarS
            // 
            this.btnAgendarS.FlatAppearance.BorderSize = 0;
            this.btnAgendarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarS.ForeColor = System.Drawing.Color.Black;
            this.btnAgendarS.Location = new System.Drawing.Point(24, 157);
            this.btnAgendarS.Name = "btnAgendarS";
            this.btnAgendarS.Size = new System.Drawing.Size(112, 49);
            this.btnAgendarS.TabIndex = 0;
            this.btnAgendarS.Text = "Agendar serviços";
            this.btnAgendarS.UseVisualStyleBackColor = true;
            this.btnAgendarS.Click += new System.EventHandler(this.btnAgendarS_Click);
            // 
            // userTelaInicial1
            // 
            this.userTelaInicial1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTelaInicial1.Location = new System.Drawing.Point(164, 37);
            this.userTelaInicial1.Name = "userTelaInicial1";
            this.userTelaInicial1.Size = new System.Drawing.Size(837, 480);
            this.userTelaInicial1.TabIndex = 23;
            // 
            // userExibirDisp1
            // 
            this.userExibirDisp1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userExibirDisp1.ForeColor = System.Drawing.Color.Transparent;
            this.userExibirDisp1.Location = new System.Drawing.Point(164, 36);
            this.userExibirDisp1.Name = "userExibirDisp1";
            this.userExibirDisp1.Size = new System.Drawing.Size(836, 480);
            this.userExibirDisp1.TabIndex = 22;
            // 
            // userManterS1
            // 
            this.userManterS1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userManterS1.Location = new System.Drawing.Point(164, 36);
            this.userManterS1.Name = "userManterS1";
            this.userManterS1.Size = new System.Drawing.Size(837, 480);
            this.userManterS1.TabIndex = 21;
            // 
            // userManterA1
            // 
            this.userManterA1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userManterA1.Location = new System.Drawing.Point(164, 36);
            this.userManterA1.Name = "userManterA1";
            this.userManterA1.Size = new System.Drawing.Size(837, 480);
            this.userManterA1.TabIndex = 20;
            // 
            // userCliente1
            // 
            this.userCliente1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCliente1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userCliente1.Location = new System.Drawing.Point(164, 36);
            this.userCliente1.Margin = new System.Windows.Forms.Padding(2);
            this.userCliente1.Name = "userCliente1";
            this.userCliente1.Size = new System.Drawing.Size(836, 480);
            this.userCliente1.TabIndex = 19;
            // 
            // userAgendarS1
            // 
            this.userAgendarS1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userAgendarS1.Location = new System.Drawing.Point(164, 36);
            this.userAgendarS1.Name = "userAgendarS1";
            this.userAgendarS1.Size = new System.Drawing.Size(836, 480);
            this.userAgendarS1.TabIndex = 18;
            // 
            // frmBalconista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.userTelaInicial1);
            this.Controls.Add(this.userExibirDisp1);
            this.Controls.Add(this.userManterS1);
            this.Controls.Add(this.userManterA1);
            this.Controls.Add(this.userCliente1);
            this.Controls.Add(this.userAgendarS1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFerramentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBalconista";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlFerramentas.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFerramentas;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnManterC;
        private System.Windows.Forms.Button btnManterS;
        private System.Windows.Forms.Button btnAgendarS;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnExibirD;
        private System.Windows.Forms.Button btnManterA;
        private UserAgendarS userAgendarS1;
        private UserCliente userCliente1;
        private UserManterA userManterA1;
        private UserManterS userManterS1;
        private UserExibirDisp userExibirDisp1;
        private UserTelaInicial userTelaInicial1;
        private System.Windows.Forms.Label label1;
    }
}


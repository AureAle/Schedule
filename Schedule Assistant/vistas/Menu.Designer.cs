namespace Schedule_Assistant
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdminProfes = new System.Windows.Forms.Button();
            this.btnCrearHorarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOpciones.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOpciones.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlOpciones.Controls.Add(this.label2);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.button1);
            this.pnlOpciones.Controls.Add(this.lbl);
            this.pnlOpciones.Controls.Add(this.btnHome);
            this.pnlOpciones.Controls.Add(this.label5);
            this.pnlOpciones.Controls.Add(this.btnAdminProfes);
            this.pnlOpciones.Controls.Add(this.btnCrearHorarios);
            this.pnlOpciones.Controls.Add(this.label3);
            this.pnlOpciones.Location = new System.Drawing.Point(3, 3);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(115, 630);
            this.pnlOpciones.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(30, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(60, 23);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "Inicio";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(26, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 64);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = " ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 46);
            this.label5.TabIndex = 25;
            this.label5.Text = "Creación\r\nde Horarios\r\n";
            // 
            // btnAdminProfes
            // 
            this.btnAdminProfes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdminProfes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminProfes.BackgroundImage")));
            this.btnAdminProfes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminProfes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfes.Location = new System.Drawing.Point(26, 151);
            this.btnAdminProfes.Name = "btnAdminProfes";
            this.btnAdminProfes.Size = new System.Drawing.Size(64, 66);
            this.btnAdminProfes.TabIndex = 21;
            this.btnAdminProfes.UseVisualStyleBackColor = false;
            this.btnAdminProfes.Click += new System.EventHandler(this.btnAdminProfes_Click);
            // 
            // btnCrearHorarios
            // 
            this.btnCrearHorarios.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCrearHorarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearHorarios.BackgroundImage")));
            this.btnCrearHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearHorarios.Location = new System.Drawing.Point(23, 323);
            this.btnCrearHorarios.Name = "btnCrearHorarios";
            this.btnCrearHorarios.Size = new System.Drawing.Size(67, 69);
            this.btnCrearHorarios.TabIndex = 24;
            this.btnCrearHorarios.UseVisualStyleBackColor = false;
            this.btnCrearHorarios.Click += new System.EventHandler(this.btnCrearHorarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 54);
            this.label3.TabIndex = 22;
            this.label3.Text = " Administración\r\n de \r\nProfesores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFondo
            // 
            this.pnlFondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFondo.Controls.Add(this.pictureBox1);
            this.pnlFondo.Controls.Add(this.lblName);
            this.pnlFondo.Controls.Add(this.pcbLogo);
            this.pnlFondo.Location = new System.Drawing.Point(119, 3);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(892, 630);
            this.pnlFondo.TabIndex = 2;
            this.pnlFondo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(770, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(330, 274);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(400, 55);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "chedule Assistant";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(158, 170);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(248, 213);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLogo.TabIndex = 3;
            this.pcbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Editar ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 65);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Horarios";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 635);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Assistant ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearHorarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdminProfes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pcbLogo;
        public System.Windows.Forms.Panel pnlFondo;
        public System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}


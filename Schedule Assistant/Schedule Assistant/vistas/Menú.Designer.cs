namespace Schedule_Assistant
{
    partial class frmMenú
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenú));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearHorarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdminProfes = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOpciones.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlOpciones.Controls.Add(this.lbl);
            this.pnlOpciones.Controls.Add(this.btnHome);
            this.pnlOpciones.Controls.Add(this.label5);
            this.pnlOpciones.Controls.Add(this.btnCrearHorarios);
            this.pnlOpciones.Controls.Add(this.label3);
            this.pnlOpciones.Controls.Add(this.btnAdminProfes);
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(119, 609);
            this.pnlOpciones.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(32, 180);
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
            this.btnHome.Location = new System.Drawing.Point(28, 113);
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
            this.label5.Location = new System.Drawing.Point(5, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 46);
            this.label5.TabIndex = 25;
            this.label5.Text = "Creación\r\nde Horarios\r\n";
            // 
            // btnCrearHorarios
            // 
            this.btnCrearHorarios.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCrearHorarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearHorarios.BackgroundImage")));
            this.btnCrearHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearHorarios.Location = new System.Drawing.Point(25, 441);
            this.btnCrearHorarios.Name = "btnCrearHorarios";
            this.btnCrearHorarios.Size = new System.Drawing.Size(67, 69);
            this.btnCrearHorarios.TabIndex = 24;
            this.btnCrearHorarios.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 54);
            this.label3.TabIndex = 22;
            this.label3.Text = " Administración\r\n de \r\nProfesores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdminProfes
            // 
            this.btnAdminProfes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdminProfes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminProfes.BackgroundImage")));
            this.btnAdminProfes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminProfes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfes.Location = new System.Drawing.Point(28, 263);
            this.btnAdminProfes.Name = "btnAdminProfes";
            this.btnAdminProfes.Size = new System.Drawing.Size(64, 66);
            this.btnAdminProfes.TabIndex = 21;
            this.btnAdminProfes.UseVisualStyleBackColor = false;
            this.btnAdminProfes.Click += new System.EventHandler(this.btnAdminProfes_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFondo.Location = new System.Drawing.Point(117, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(849, 609);
            this.pnlFondo.TabIndex = 2;
            this.pnlFondo.Visible = false;
            // 
            // frmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 609);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Assistant ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearHorarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdminProfes;
        private System.Windows.Forms.Panel pnlFondo;
    }
}


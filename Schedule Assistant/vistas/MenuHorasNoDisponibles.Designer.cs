namespace Schedule_Assistant
{
    partial class MenuHorasNoDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHorasNoDisponibles));
            this.bttnEliminarHoraProfesor = new System.Windows.Forms.Button();
            this.lstListaHorariosProfesor = new System.Windows.Forms.ListBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.bttnAgregarHorario = new System.Windows.Forms.Button();
            this.pnlProfe = new System.Windows.Forms.Panel();
            this.lblMaestros = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.pnlProfe.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnEliminarHoraProfesor
            // 
            this.bttnEliminarHoraProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminarHoraProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminarHoraProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnEliminarHoraProfesor.Location = new System.Drawing.Point(120, 363);
            this.bttnEliminarHoraProfesor.Name = "bttnEliminarHoraProfesor";
            this.bttnEliminarHoraProfesor.Size = new System.Drawing.Size(128, 32);
            this.bttnEliminarHoraProfesor.TabIndex = 20;
            this.bttnEliminarHoraProfesor.Text = "Eliminar Hora";
            this.bttnEliminarHoraProfesor.UseVisualStyleBackColor = true;
            this.bttnEliminarHoraProfesor.Click += new System.EventHandler(this.bttnEliminarHoraProfesor_Click);
            // 
            // lstListaHorariosProfesor
            // 
            this.lstListaHorariosProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaHorariosProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstListaHorariosProfesor.FormattingEnabled = true;
            this.lstListaHorariosProfesor.ItemHeight = 20;
            this.lstListaHorariosProfesor.Location = new System.Drawing.Point(287, 177);
            this.lstListaHorariosProfesor.Name = "lstListaHorariosProfesor";
            this.lstListaHorariosProfesor.Size = new System.Drawing.Size(261, 224);
            this.lstListaHorariosProfesor.TabIndex = 21;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHora.Location = new System.Drawing.Point(14, 247);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora:";
            // 
            // cmbHora
            // 
            this.cmbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "2:10-3:00",
            "3:00-3:50",
            "3:50-4:40",
            "5:10-6:00",
            "6:00-6:50",
            "6:50-7:40",
            "7:40-8:30"});
            this.cmbHora.Location = new System.Drawing.Point(69, 244);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(179, 28);
            this.cmbHora.TabIndex = 19;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDia.Location = new System.Drawing.Point(25, 180);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(37, 20);
            this.lblDia.TabIndex = 16;
            this.lblDia.Text = "Día:";
            // 
            // cmbDia
            // 
            this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cmbDia.Location = new System.Drawing.Point(69, 177);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(179, 28);
            this.cmbDia.TabIndex = 17;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // bttnAgregarHorario
            // 
            this.bttnAgregarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarHorario.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnAgregarHorario.Location = new System.Drawing.Point(120, 311);
            this.bttnAgregarHorario.Name = "bttnAgregarHorario";
            this.bttnAgregarHorario.Size = new System.Drawing.Size(128, 30);
            this.bttnAgregarHorario.TabIndex = 15;
            this.bttnAgregarHorario.Text = "Agregar Hora";
            this.bttnAgregarHorario.UseVisualStyleBackColor = false;
            this.bttnAgregarHorario.Click += new System.EventHandler(this.bttnAgregarHorario_Click);
            // 
            // pnlProfe
            // 
            this.pnlProfe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProfe.Controls.Add(this.lblMaestros);
            this.pnlProfe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfe.Location = new System.Drawing.Point(0, 0);
            this.pnlProfe.Name = "pnlProfe";
            this.pnlProfe.Size = new System.Drawing.Size(615, 56);
            this.pnlProfe.TabIndex = 33;
            // 
            // lblMaestros
            // 
            this.lblMaestros.AutoSize = true;
            this.lblMaestros.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestros.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaestros.Location = new System.Drawing.Point(131, 5);
            this.lblMaestros.Name = "lblMaestros";
            this.lblMaestros.Size = new System.Drawing.Size(382, 50);
            this.lblMaestros.TabIndex = 1;
            this.lblMaestros.Text = "Horas no disponibles ";
            this.lblMaestros.Click += new System.EventHandler(this.lblMaestros_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHoras.Location = new System.Drawing.Point(23, 83);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(135, 39);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "Profesor:";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombreProfe.Location = new System.Drawing.Point(162, 83);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(0, 33);
            this.lblNombreProfe.TabIndex = 34;
            // 
            // MenuHorasNoDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 443);
            this.Controls.Add(this.lblNombreProfe);
            this.Controls.Add(this.pnlProfe);
            this.Controls.Add(this.bttnEliminarHoraProfesor);
            this.Controls.Add(this.lstListaHorariosProfesor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.bttnAgregarHorario);
            this.Controls.Add(this.lblHoras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuHorasNoDisponibles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenúHorasNoDisponibles";
            this.pnlProfe.ResumeLayout(false);
            this.pnlProfe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnEliminarHoraProfesor;
        private System.Windows.Forms.ListBox lstListaHorariosProfesor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Button bttnAgregarHorario;
        private System.Windows.Forms.Panel pnlProfe;
        private System.Windows.Forms.Label lblMaestros;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblNombreProfe;
    }
}
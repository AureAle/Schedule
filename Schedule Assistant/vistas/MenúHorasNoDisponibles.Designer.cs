namespace Schedule_Assistant
{
    partial class MenúHorasNoDisponibles
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
            this.lblHoras = new System.Windows.Forms.Label();
            this.bttnEliminarHoraProfesor = new System.Windows.Forms.Button();
            this.lstListaHorariosProfesor = new System.Windows.Forms.ListBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.bttnAgregarHorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHoras.Location = new System.Drawing.Point(219, 113);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(384, 50);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "Horas No Disponibles";
            // 
            // bttnEliminarHoraProfesor
            // 
            this.bttnEliminarHoraProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminarHoraProfesor.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminarHoraProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnEliminarHoraProfesor.Location = new System.Drawing.Point(223, 426);
            this.bttnEliminarHoraProfesor.Name = "bttnEliminarHoraProfesor";
            this.bttnEliminarHoraProfesor.Size = new System.Drawing.Size(128, 32);
            this.bttnEliminarHoraProfesor.TabIndex = 20;
            this.bttnEliminarHoraProfesor.Text = "Eliminar Hora";
            this.bttnEliminarHoraProfesor.UseVisualStyleBackColor = true;
            // 
            // lstListaHorariosProfesor
            // 
            this.lstListaHorariosProfesor.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaHorariosProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstListaHorariosProfesor.FormattingEnabled = true;
            this.lstListaHorariosProfesor.ItemHeight = 21;
            this.lstListaHorariosProfesor.Location = new System.Drawing.Point(418, 238);
            this.lstListaHorariosProfesor.Name = "lstListaHorariosProfesor";
            this.lstListaHorariosProfesor.Size = new System.Drawing.Size(307, 340);
            this.lstListaHorariosProfesor.TabIndex = 21;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHora.Location = new System.Drawing.Point(117, 310);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(49, 21);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora:";
            // 
            // cmbHora
            // 
            this.cmbHora.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbHora.Location = new System.Drawing.Point(172, 307);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(179, 29);
            this.cmbHora.TabIndex = 19;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDia.Location = new System.Drawing.Point(128, 243);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(38, 21);
            this.lblDia.TabIndex = 16;
            this.lblDia.Text = "Día:";
            // 
            // cmbDia
            // 
            this.cmbDia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cmbDia.Location = new System.Drawing.Point(172, 240);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(179, 29);
            this.cmbDia.TabIndex = 17;
            // 
            // bttnAgregarHorario
            // 
            this.bttnAgregarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregarHorario.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarHorario.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnAgregarHorario.Location = new System.Drawing.Point(223, 374);
            this.bttnAgregarHorario.Name = "bttnAgregarHorario";
            this.bttnAgregarHorario.Size = new System.Drawing.Size(128, 30);
            this.bttnAgregarHorario.TabIndex = 15;
            this.bttnAgregarHorario.Text = "Agregar Hora";
            this.bttnAgregarHorario.UseVisualStyleBackColor = false;
            // 
            // MenúHorasNoDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 691);
            this.Controls.Add(this.bttnEliminarHoraProfesor);
            this.Controls.Add(this.lstListaHorariosProfesor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.bttnAgregarHorario);
            this.Controls.Add(this.lblHoras);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenúHorasNoDisponibles";
            this.Text = "MenúHorasNoDisponibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button bttnEliminarHoraProfesor;
        private System.Windows.Forms.ListBox lstListaHorariosProfesor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Button bttnAgregarHorario;
    }
}
namespace Schedule_Assistant
{
    partial class MenúMaestro
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
            this.lblMaestros = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.bttnAgregarProfesor = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.bttnHorariosProfesor = new System.Windows.Forms.Button();
            this.bttnModificarMaterias = new System.Windows.Forms.Button();
            this.bttnEliminarProfesor = new System.Windows.Forms.Button();
            this.bttnModificarProfesor = new System.Windows.Forms.Button();
            this.bttnGuardarNuevoNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaestros
            // 
            this.lblMaestros.AutoSize = true;
            this.lblMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestros.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaestros.Location = new System.Drawing.Point(428, 40);
            this.lblMaestros.Name = "lblMaestros";
            this.lblMaestros.Size = new System.Drawing.Size(172, 42);
            this.lblMaestros.TabIndex = 1;
            this.lblMaestros.Text = "Maestros";
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProfesor.Location = new System.Drawing.Point(366, 176);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(294, 26);
            this.txtNombreProfesor.TabIndex = 2;
            this.txtNombreProfesor.Click += new System.EventHandler(this.txtNombreProfesor_Click);
            this.txtNombreProfesor.Leave += new System.EventHandler(this.txtNombreProfesor_Leave);
            // 
            // bttnAgregarProfesor
            // 
            this.bttnAgregarProfesor.BackColor = System.Drawing.Color.Transparent;
            this.bttnAgregarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnAgregarProfesor.Location = new System.Drawing.Point(666, 172);
            this.bttnAgregarProfesor.Name = "bttnAgregarProfesor";
            this.bttnAgregarProfesor.Size = new System.Drawing.Size(93, 36);
            this.bttnAgregarProfesor.TabIndex = 3;
            this.bttnAgregarProfesor.Text = "Agregar";
            this.bttnAgregarProfesor.UseVisualStyleBackColor = false;
            this.bttnAgregarProfesor.Click += new System.EventHandler(this.bttnAgregarProfesor_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName.Location = new System.Drawing.Point(223, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Nombre completo:";
            // 
            // lstProfesores
            // 
            this.lstProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfesores.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.ItemHeight = 20;
            this.lstProfesores.Location = new System.Drawing.Point(227, 232);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(532, 324);
            this.lstProfesores.TabIndex = 10;
            this.lstProfesores.SelectedIndexChanged += new System.EventHandler(this.lstProfesores_SelectedIndexChanged);
            // 
            // bttnHorariosProfesor
            // 
            this.bttnHorariosProfesor.BackColor = System.Drawing.Color.Transparent;
            this.bttnHorariosProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHorariosProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHorariosProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnHorariosProfesor.Location = new System.Drawing.Point(584, 594);
            this.bttnHorariosProfesor.Name = "bttnHorariosProfesor";
            this.bttnHorariosProfesor.Size = new System.Drawing.Size(90, 46);
            this.bttnHorariosProfesor.TabIndex = 28;
            this.bttnHorariosProfesor.Text = "Horarios";
            this.bttnHorariosProfesor.UseVisualStyleBackColor = false;
            this.bttnHorariosProfesor.Click += new System.EventHandler(this.bttnHorariosProfesor_Click);
            // 
            // bttnModificarMaterias
            // 
            this.bttnModificarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModificarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificarMaterias.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnModificarMaterias.Location = new System.Drawing.Point(502, 594);
            this.bttnModificarMaterias.Name = "bttnModificarMaterias";
            this.bttnModificarMaterias.Size = new System.Drawing.Size(90, 46);
            this.bttnModificarMaterias.TabIndex = 30;
            this.bttnModificarMaterias.Text = "Materias";
            this.bttnModificarMaterias.UseVisualStyleBackColor = false;
            // 
            // bttnEliminarProfesor
            // 
            this.bttnEliminarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminarProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnEliminarProfesor.Location = new System.Drawing.Point(418, 594);
            this.bttnEliminarProfesor.Name = "bttnEliminarProfesor";
            this.bttnEliminarProfesor.Size = new System.Drawing.Size(90, 46);
            this.bttnEliminarProfesor.TabIndex = 29;
            this.bttnEliminarProfesor.Text = "Eliminar";
            this.bttnEliminarProfesor.UseVisualStyleBackColor = false;
            this.bttnEliminarProfesor.Click += new System.EventHandler(this.bttnEliminarProfesor_Click);
            // 
            // bttnModificarProfesor
            // 
            this.bttnModificarProfesor.BackColor = System.Drawing.Color.Transparent;
            this.bttnModificarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModificarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificarProfesor.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnModificarProfesor.Location = new System.Drawing.Point(334, 594);
            this.bttnModificarProfesor.Name = "bttnModificarProfesor";
            this.bttnModificarProfesor.Size = new System.Drawing.Size(86, 46);
            this.bttnModificarProfesor.TabIndex = 27;
            this.bttnModificarProfesor.Text = "Modificar";
            this.bttnModificarProfesor.UseVisualStyleBackColor = false;
            this.bttnModificarProfesor.Click += new System.EventHandler(this.bttnModificarProfesor_Click);
            // 
            // bttnGuardarNuevoNombre
            // 
            this.bttnGuardarNuevoNombre.BackColor = System.Drawing.Color.Transparent;
            this.bttnGuardarNuevoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardarNuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardarNuevoNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnGuardarNuevoNombre.Location = new System.Drawing.Point(677, 172);
            this.bttnGuardarNuevoNombre.Name = "bttnGuardarNuevoNombre";
            this.bttnGuardarNuevoNombre.Size = new System.Drawing.Size(93, 36);
            this.bttnGuardarNuevoNombre.TabIndex = 31;
            this.bttnGuardarNuevoNombre.Text = "Guardar";
            this.bttnGuardarNuevoNombre.UseVisualStyleBackColor = false;
            this.bttnGuardarNuevoNombre.Click += new System.EventHandler(this.bttnGuardarNuevoNombre_Click);
            // 
            // MenúMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 680);
            this.Controls.Add(this.bttnGuardarNuevoNombre);
            this.Controls.Add(this.bttnHorariosProfesor);
            this.Controls.Add(this.bttnModificarMaterias);
            this.Controls.Add(this.bttnEliminarProfesor);
            this.Controls.Add(this.bttnModificarProfesor);
            this.Controls.Add(this.lstProfesores);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.bttnAgregarProfesor);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(this.lblMaestros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenúMaestro";
            this.Text = "Maestro";
            this.Click += new System.EventHandler(this.MenúMaestro_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaestros;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Button bttnAgregarProfesor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.Button bttnHorariosProfesor;
        private System.Windows.Forms.Button bttnModificarMaterias;
        private System.Windows.Forms.Button bttnEliminarProfesor;
        private System.Windows.Forms.Button bttnModificarProfesor;
        private System.Windows.Forms.Button bttnGuardarNuevoNombre;
    }
}
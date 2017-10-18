namespace Schedule_Assistant
{
    partial class MenúMaterias
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
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.bttnBorrarMateria = new System.Windows.Forms.Button();
            this.lstListaMateriasProfesores = new System.Windows.Forms.ListBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.bttnAgregarMaterias = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtMateria.Location = new System.Drawing.Point(281, 200);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(292, 26);
            this.txtMateria.TabIndex = 19;
            // 
            // bttnBorrarMateria
            // 
            this.bttnBorrarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBorrarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBorrarMateria.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnBorrarMateria.Location = new System.Drawing.Point(213, 544);
            this.bttnBorrarMateria.Name = "bttnBorrarMateria";
            this.bttnBorrarMateria.Size = new System.Drawing.Size(146, 32);
            this.bttnBorrarMateria.TabIndex = 18;
            this.bttnBorrarMateria.Text = "Eliminar Materia";
            this.bttnBorrarMateria.UseVisualStyleBackColor = true;
            // 
            // lstListaMateriasProfesores
            // 
            this.lstListaMateriasProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaMateriasProfesores.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstListaMateriasProfesores.FormattingEnabled = true;
            this.lstListaMateriasProfesores.ItemHeight = 20;
            this.lstListaMateriasProfesores.Location = new System.Drawing.Point(213, 252);
            this.lstListaMateriasProfesores.Name = "lstListaMateriasProfesores";
            this.lstListaMateriasProfesores.Size = new System.Drawing.Size(360, 264);
            this.lstListaMateriasProfesores.TabIndex = 17;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMateria.Location = new System.Drawing.Point(209, 204);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 20);
            this.lblMateria.TabIndex = 16;
            this.lblMateria.Text = "Materia:";
            // 
            // bttnAgregarMaterias
            // 
            this.bttnAgregarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarMaterias.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnAgregarMaterias.Location = new System.Drawing.Point(427, 544);
            this.bttnAgregarMaterias.Name = "bttnAgregarMaterias";
            this.bttnAgregarMaterias.Size = new System.Drawing.Size(146, 32);
            this.bttnAgregarMaterias.TabIndex = 15;
            this.bttnAgregarMaterias.Text = "Agregar Materia";
            this.bttnAgregarMaterias.UseVisualStyleBackColor = false;
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaterias.Location = new System.Drawing.Point(330, 106);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(161, 42);
            this.lblMaterias.TabIndex = 20;
            this.lblMaterias.Text = "Materias";
            // 
            // MenúMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 683);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.bttnBorrarMateria);
            this.Controls.Add(this.lstListaMateriasProfesores);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.bttnAgregarMaterias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenúMaterias";
            this.Text = "MenúMaterias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button bttnBorrarMateria;
        private System.Windows.Forms.ListBox lstListaMateriasProfesores;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button bttnAgregarMaterias;
        private System.Windows.Forms.Label lblMaterias;
    }
}
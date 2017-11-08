namespace Schedule_Assistant
{
    partial class MenuMaterias
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttnModificarCreditos = new System.Windows.Forms.Button();
            this.bttnGuardarCreditos = new System.Windows.Forms.Button();
            this.pnlProfe = new System.Windows.Forms.Panel();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblNProfe = new System.Windows.Forms.Label();
            this.UpDwnCreditos = new System.Windows.Forms.NumericUpDown();
            this.pnlProfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDwnCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtMateria.Location = new System.Drawing.Point(157, 142);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(225, 26);
            this.txtMateria.TabIndex = 19;
            // 
            // bttnBorrarMateria
            // 
            this.bttnBorrarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBorrarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBorrarMateria.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnBorrarMateria.Location = new System.Drawing.Point(89, 487);
            this.bttnBorrarMateria.Name = "bttnBorrarMateria";
            this.bttnBorrarMateria.Size = new System.Drawing.Size(146, 32);
            this.bttnBorrarMateria.TabIndex = 18;
            this.bttnBorrarMateria.Text = "Eliminar Materia";
            this.bttnBorrarMateria.UseVisualStyleBackColor = true;
            this.bttnBorrarMateria.Click += new System.EventHandler(this.bttnBorrarMateria_Click);
            // 
            // lstListaMateriasProfesores
            // 
            this.lstListaMateriasProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaMateriasProfesores.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstListaMateriasProfesores.FormattingEnabled = true;
            this.lstListaMateriasProfesores.ItemHeight = 20;
            this.lstListaMateriasProfesores.Location = new System.Drawing.Point(89, 195);
            this.lstListaMateriasProfesores.Name = "lstListaMateriasProfesores";
            this.lstListaMateriasProfesores.Size = new System.Drawing.Size(491, 264);
            this.lstListaMateriasProfesores.TabIndex = 17;
            this.lstListaMateriasProfesores.SelectedIndexChanged += new System.EventHandler(this.lstListaMateriasProfesores_SelectedIndexChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMateria.Location = new System.Drawing.Point(85, 146);
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
            this.bttnAgregarMaterias.Location = new System.Drawing.Point(261, 487);
            this.bttnAgregarMaterias.Name = "bttnAgregarMaterias";
            this.bttnAgregarMaterias.Size = new System.Drawing.Size(146, 32);
            this.bttnAgregarMaterias.TabIndex = 15;
            this.bttnAgregarMaterias.Text = "Agregar Materia";
            this.bttnAgregarMaterias.UseVisualStyleBackColor = false;
            this.bttnAgregarMaterias.Click += new System.EventHandler(this.bttnAgregarMaterias_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaterias.Location = new System.Drawing.Point(263, 9);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(161, 42);
            this.lblMaterias.TabIndex = 20;
            this.lblMaterias.Text = "Materias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(400, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Créditos:";
            // 
            // bttnModificarCreditos
            // 
            this.bttnModificarCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModificarCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificarCreditos.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnModificarCreditos.Location = new System.Drawing.Point(433, 487);
            this.bttnModificarCreditos.Name = "bttnModificarCreditos";
            this.bttnModificarCreditos.Size = new System.Drawing.Size(146, 32);
            this.bttnModificarCreditos.TabIndex = 23;
            this.bttnModificarCreditos.Text = "Modificar Créditos";
            this.bttnModificarCreditos.UseVisualStyleBackColor = true;
            this.bttnModificarCreditos.Click += new System.EventHandler(this.bttnModificarCreditos_Click);
            // 
            // bttnGuardarCreditos
            // 
            this.bttnGuardarCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardarCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardarCreditos.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnGuardarCreditos.Location = new System.Drawing.Point(598, 139);
            this.bttnGuardarCreditos.Name = "bttnGuardarCreditos";
            this.bttnGuardarCreditos.Size = new System.Drawing.Size(97, 32);
            this.bttnGuardarCreditos.TabIndex = 24;
            this.bttnGuardarCreditos.Text = "Guardar";
            this.bttnGuardarCreditos.UseVisualStyleBackColor = true;
            this.bttnGuardarCreditos.Click += new System.EventHandler(this.bttnGuardarCreditos_Click);
            // 
            // pnlProfe
            // 
            this.pnlProfe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProfe.Controls.Add(this.lblMaterias);
            this.pnlProfe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfe.Location = new System.Drawing.Point(0, 0);
            this.pnlProfe.Name = "pnlProfe";
            this.pnlProfe.Size = new System.Drawing.Size(704, 56);
            this.pnlProfe.TabIndex = 33;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHoras.Location = new System.Drawing.Point(18, 77);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(133, 33);
            this.lblHoras.TabIndex = 34;
            this.lblHoras.Text = "Profesor:";
            // 
            // lblNProfe
            // 
            this.lblNProfe.AutoSize = true;
            this.lblNProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNProfe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNProfe.Location = new System.Drawing.Point(157, 77);
            this.lblNProfe.Name = "lblNProfe";
            this.lblNProfe.Size = new System.Drawing.Size(0, 33);
            this.lblNProfe.TabIndex = 35;
            // 
            // UpDwnCreditos
            // 
            this.UpDwnCreditos.ForeColor = System.Drawing.Color.SteelBlue;
            this.UpDwnCreditos.Location = new System.Drawing.Point(478, 145);
            this.UpDwnCreditos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDwnCreditos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDwnCreditos.Name = "UpDwnCreditos";
            this.UpDwnCreditos.Size = new System.Drawing.Size(72, 26);
            this.UpDwnCreditos.TabIndex = 36;
            this.UpDwnCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDwnCreditos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MenuMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 535);
            this.Controls.Add(this.UpDwnCreditos);
            this.Controls.Add(this.lblNProfe);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.pnlProfe);
            this.Controls.Add(this.bttnGuardarCreditos);
            this.Controls.Add(this.bttnModificarCreditos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.bttnBorrarMateria);
            this.Controls.Add(this.lstListaMateriasProfesores);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.bttnAgregarMaterias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenúMaterias";
            this.Click += new System.EventHandler(this.MenuMaterias_Click);
            this.pnlProfe.ResumeLayout(false);
            this.pnlProfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDwnCreditos)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnModificarCreditos;
        private System.Windows.Forms.Button bttnGuardarCreditos;
        private System.Windows.Forms.Panel pnlProfe;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblNProfe;
        private System.Windows.Forms.NumericUpDown UpDwnCreditos;
    }
}
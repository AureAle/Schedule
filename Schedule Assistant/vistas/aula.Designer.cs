namespace Schedule_Assistant.vistas
{
    partial class aula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aula));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAula = new System.Windows.Forms.ComboBox();
            this.bttnGuardarAula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(55, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elija una aula";
            // 
            // cmbAula
            // 
            this.cmbAula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAula.FormattingEnabled = true;
            this.cmbAula.Items.AddRange(new object[] {
            "Auditorio 1",
            "Auditorio 2",
            "Auditorio 3",
            "Auditorio 4",
            "Aula 1",
            "Aula 1 PS",
            "Aula 3 PS",
            "CC. Posgrado",
            "D Comp Lab",
            "L. Arquitectura",
            "L. CISCO",
            "L. Redes",
            "Laboratorio 1",
            "Laboratorio 2",
            "Laboratorio 3",
            "Laboratorio 4",
            "Laboratorio 5"});
            this.cmbAula.Location = new System.Drawing.Point(49, 77);
            this.cmbAula.Name = "cmbAula";
            this.cmbAula.Size = new System.Drawing.Size(121, 21);
            this.cmbAula.TabIndex = 4;
            // 
            // bttnGuardarAula
            // 
            this.bttnGuardarAula.BackColor = System.Drawing.Color.Transparent;
            this.bttnGuardarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardarAula.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardarAula.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnGuardarAula.Location = new System.Drawing.Point(31, 114);
            this.bttnGuardarAula.Name = "bttnGuardarAula";
            this.bttnGuardarAula.Size = new System.Drawing.Size(168, 31);
            this.bttnGuardarAula.TabIndex = 33;
            this.bttnGuardarAula.Text = "Aceptar";
            this.bttnGuardarAula.UseVisualStyleBackColor = false;
            this.bttnGuardarAula.Click += new System.EventHandler(this.bttnGuardarAula_Click);
            // 
            // aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(231, 157);
            this.Controls.Add(this.bttnGuardarAula);
            this.Controls.Add(this.cmbAula);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAula;
        private System.Windows.Forms.Button bttnGuardarAula;
    }
}
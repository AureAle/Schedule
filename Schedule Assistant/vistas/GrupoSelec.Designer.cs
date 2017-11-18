namespace Schedule_Assistant
{
    partial class GrupoSelec
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
            this.lstGrupos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAceptarGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGrupos
            // 
            this.lstGrupos.FormattingEnabled = true;
            this.lstGrupos.Location = new System.Drawing.Point(12, 47);
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(120, 212);
            this.lstGrupos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el grupo:";
            // 
            // bttnAceptarGrupo
            // 
            this.bttnAceptarGrupo.Location = new System.Drawing.Point(31, 265);
            this.bttnAceptarGrupo.Name = "bttnAceptarGrupo";
            this.bttnAceptarGrupo.Size = new System.Drawing.Size(75, 23);
            this.bttnAceptarGrupo.TabIndex = 2;
            this.bttnAceptarGrupo.Text = "Aceptar";
            this.bttnAceptarGrupo.UseVisualStyleBackColor = true;
            this.bttnAceptarGrupo.Click += new System.EventHandler(this.bttnAceptarGrupo_Click);
            // 
            // GrupoSelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 308);
            this.Controls.Add(this.bttnAceptarGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGrupos);
            this.Name = "GrupoSelec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrupoSelec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GrupoSelec_FormClosing);
            this.Load += new System.EventHandler(this.GrupoSelec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAceptarGrupo;
    }
}
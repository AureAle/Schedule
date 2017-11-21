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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoSelec));
            this.lstGrupos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAceptarGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGrupos
            // 
            this.lstGrupos.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGrupos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstGrupos.FormattingEnabled = true;
            this.lstGrupos.ItemHeight = 18;
            this.lstGrupos.Location = new System.Drawing.Point(23, 47);
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(120, 202);
            this.lstGrupos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el grupo:";
            // 
            // bttnAceptarGrupo
            // 
            this.bttnAceptarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.bttnAceptarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAceptarGrupo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAceptarGrupo.ForeColor = System.Drawing.Color.SteelBlue;
            this.bttnAceptarGrupo.Location = new System.Drawing.Point(41, 265);
            this.bttnAceptarGrupo.Name = "bttnAceptarGrupo";
            this.bttnAceptarGrupo.Size = new System.Drawing.Size(84, 31);
            this.bttnAceptarGrupo.TabIndex = 2;
            this.bttnAceptarGrupo.Text = "Aceptar";
            this.bttnAceptarGrupo.UseVisualStyleBackColor = false;
            this.bttnAceptarGrupo.Click += new System.EventHandler(this.bttnAceptarGrupo_Click);
            // 
            // GrupoSelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(167, 308);
            this.Controls.Add(this.bttnAceptarGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGrupos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrupoSelec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo";
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
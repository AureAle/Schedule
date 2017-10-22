namespace Schedule_Assistant.vistas
{
    partial class CrearHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearHorarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProfe = new System.Windows.Forms.Panel();
            this.lblMaestros = new System.Windows.Forms.Label();
            this.pnlProfe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(247, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 626);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 629);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlProfe
            // 
            this.pnlProfe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProfe.Controls.Add(this.lblMaestros);
            this.pnlProfe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfe.Location = new System.Drawing.Point(0, 0);
            this.pnlProfe.Name = "pnlProfe";
            this.pnlProfe.Size = new System.Drawing.Size(1277, 56);
            this.pnlProfe.TabIndex = 33;
            // 
            // lblMaestros
            // 
            this.lblMaestros.AutoSize = true;
            this.lblMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestros.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaestros.Location = new System.Drawing.Point(403, 9);
            this.lblMaestros.Name = "lblMaestros";
            this.lblMaestros.Size = new System.Drawing.Size(264, 42);
            this.lblMaestros.TabIndex = 1;
            this.lblMaestros.Text = "Horario Grupo:";
            // 
            // CrearHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1294, 681);
            this.Controls.Add(this.pnlProfe);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(117, 0);
            this.Name = "CrearHorarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrearHorarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrearHorarios_Load);
            this.pnlProfe.ResumeLayout(false);
            this.pnlProfe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlProfe;
        private System.Windows.Forms.Label lblMaestros;
    }
}
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
            this.tablePanelHorairo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProfe = new System.Windows.Forms.Panel();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnExportar = new System.Windows.Forms.Button();
            this.botonClase1 = new Schedule_Assistant.componenetes_graficos.botonClase();
            this.panel1.SuspendLayout();
            this.pnlProfe.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.tablePanelHorairo);
            this.panel1.Location = new System.Drawing.Point(166, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 630);
            this.panel1.TabIndex = 0;
            // 
            // tablePanelHorairo
            // 
            this.tablePanelHorairo.BackColor = System.Drawing.Color.Transparent;
            this.tablePanelHorairo.ColumnCount = 5;
            this.tablePanelHorairo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelHorairo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelHorairo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelHorairo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.15334F));
            this.tablePanelHorairo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.04381F));
            this.tablePanelHorairo.Location = new System.Drawing.Point(117, 29);
            this.tablePanelHorairo.Name = "tablePanelHorairo";
            this.tablePanelHorairo.RowCount = 8;
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.81198F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.14642F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.14642F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47754F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.81364F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29508F));
            this.tablePanelHorairo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelHorairo.Size = new System.Drawing.Size(913, 601);
            this.tablePanelHorairo.TabIndex = 0;
            // 
            // pnlProfe
            // 
            this.pnlProfe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProfe.Controls.Add(this.lblGrupo);
            this.pnlProfe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfe.Location = new System.Drawing.Point(0, 0);
            this.pnlProfe.Name = "pnlProfe";
            this.pnlProfe.Size = new System.Drawing.Size(1196, 56);
            this.pnlProfe.TabIndex = 33;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGrupo.Location = new System.Drawing.Point(504, 4);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(264, 42);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "Horario Grupo:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.botonClase1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 626);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // bttnExportar
            // 
            this.bttnExportar.Location = new System.Drawing.Point(12, 12);
            this.bttnExportar.Name = "bttnExportar";
            this.bttnExportar.Size = new System.Drawing.Size(75, 23);
            this.bttnExportar.TabIndex = 2;
            this.bttnExportar.Text = "Exportar";
            this.bttnExportar.UseVisualStyleBackColor = true;
            this.bttnExportar.Click += new System.EventHandler(this.bttnExportar_Click);
            // 
            // botonClase1
            // 
            this.botonClase1.Disponibles = 0;
            this.botonClase1.Location = new System.Drawing.Point(3, 3);
            this.botonClase1.Name = "botonClase1";
            this.botonClase1.Size = new System.Drawing.Size(157, 50);
            this.botonClase1.TabIndex = 0;
            this.botonClase1.Text = "botonClase1";
            this.botonClase1.UseVisualStyleBackColor = true;
            // 
            // CrearHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 647);
            this.Controls.Add(this.bttnExportar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlProfe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(117, 0);
            this.Name = "CrearHorarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CrearHorarios";
            this.Load += new System.EventHandler(this.CrearHorarios_Load);
            this.VisibleChanged += new System.EventHandler(this.CrearHorarios_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.pnlProfe.ResumeLayout(false);
            this.pnlProfe.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProfe;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tablePanelHorairo;
        private componenetes_graficos.botonClase botonClase1;
        private System.Windows.Forms.Button bttnExportar;
    }
}
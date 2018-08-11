namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class ReportesHorarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesHorarios));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.curos_horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteProfesoresCurso = new Aplicaciones_En_Ambientes_Porpietarios.reporteProfesoresCurso();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.curos_horarioTableAdapter = new Aplicaciones_En_Ambientes_Porpietarios.reporteProfesoresCursoTableAdapters.curos_horarioTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.curos_horarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProfesoresCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // curos_horarioBindingSource
            // 
            this.curos_horarioBindingSource.DataMember = "curos_horario";
            this.curos_horarioBindingSource.DataSource = this.reporteProfesoresCurso;
            // 
            // reporteProfesoresCurso
            // 
            this.reporteProfesoresCurso.DataSetName = "reporteProfesoresCurso";
            this.reporteProfesoresCurso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(737, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 81;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Regresar");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 84;
            this.label1.Text = "Reporte Profesores por Curso";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.curos_horarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplicaciones_En_Ambientes_Porpietarios.reporteHorario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(787, 361);
            this.reportViewer1.TabIndex = 85;
            // 
            // curos_horarioTableAdapter
            // 
            this.curos_horarioTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 414);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "/";
            this.Load += new System.EventHandler(this.ReportesHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.curos_horarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProfesoresCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource curos_horarioBindingSource;
        private reporteProfesoresCurso reporteProfesoresCurso;
        private reporteProfesoresCursoTableAdapters.curos_horarioTableAdapter curos_horarioTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
﻿namespace QuanLyKho.VIEW
{
    partial class frmInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyKhoDataSet = new QuanLyKho.QuanLyKhoDataSet();
            this.inHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inHoaDonTableAdapter = new QuanLyKho.QuanLyKhoDataSetTableAdapters.InHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.inHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKho.VIEW.HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(788, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyKhoDataSet
            // 
            this.quanLyKhoDataSet.DataSetName = "QuanLyKhoDataSet";
            this.quanLyKhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inHoaDonBindingSource
            // 
            this.inHoaDonBindingSource.DataMember = "InHoaDon";
            this.inHoaDonBindingSource.DataSource = this.quanLyKhoDataSet;
            // 
            // inHoaDonTableAdapter
            // 
            this.inHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 413);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHoaDon";
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyKhoDataSet quanLyKhoDataSet;
        private System.Windows.Forms.BindingSource inHoaDonBindingSource;
        private QuanLyKhoDataSetTableAdapters.InHoaDonTableAdapter inHoaDonTableAdapter;
    }
}
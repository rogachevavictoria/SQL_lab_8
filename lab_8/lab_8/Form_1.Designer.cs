namespace lab_8
{
    partial class Form_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.var5sqlDataSet_views = new lab_8.var5sqlDataSet_views();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new lab_8.var5sqlDataSet_viewsTableAdapters.view_1TableAdapter();
            this.abonnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMPRISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCHKNAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_2TableAdapter = new lab_8.var5sqlDataSet_viewsTableAdapters.view_2TableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.view3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_3TableAdapter = new lab_8.var5sqlDataSet_viewsTableAdapters.view_3TableAdapter();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchkplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSet_views)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abonnamDataGridViewTextBoxColumn,
            this.nAMPRISDataGridViewTextBoxColumn,
            this.tCHKNAMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(347, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // var5sqlDataSet_views
            // 
            this.var5sqlDataSet_views.DataSetName = "var5sqlDataSet_views";
            this.var5sqlDataSet_views.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "view_1";
            this.view1BindingSource.DataSource = this.var5sqlDataSet_views;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // abonnamDataGridViewTextBoxColumn
            // 
            this.abonnamDataGridViewTextBoxColumn.DataPropertyName = "abon_nam";
            this.abonnamDataGridViewTextBoxColumn.HeaderText = "abon_nam";
            this.abonnamDataGridViewTextBoxColumn.Name = "abonnamDataGridViewTextBoxColumn";
            // 
            // nAMPRISDataGridViewTextBoxColumn
            // 
            this.nAMPRISDataGridViewTextBoxColumn.DataPropertyName = "NAM_PRIS";
            this.nAMPRISDataGridViewTextBoxColumn.HeaderText = "NAM_PRIS";
            this.nAMPRISDataGridViewTextBoxColumn.Name = "nAMPRISDataGridViewTextBoxColumn";
            // 
            // tCHKNAMDataGridViewTextBoxColumn
            // 
            this.tCHKNAMDataGridViewTextBoxColumn.DataPropertyName = "TCHK_NAM";
            this.tCHKNAMDataGridViewTextBoxColumn.HeaderText = "TCHK_NAM";
            this.tCHKNAMDataGridViewTextBoxColumn.Name = "tCHKNAMDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.view2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(365, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(145, 329);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "abon_nam";
            this.dataGridViewTextBoxColumn1.HeaderText = "abon_nam";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "view_2";
            this.view2BindingSource.DataSource = this.var5sqlDataSet_views;
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeDataGridViewTextBoxColumn,
            this.tchkplaceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.view3BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(516, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(251, 329);
            this.dataGridView3.TabIndex = 2;
            // 
            // view3BindingSource
            // 
            this.view3BindingSource.DataMember = "view_3";
            this.view3BindingSource.DataSource = this.var5sqlDataSet_views;
            // 
            // view_3TableAdapter
            // 
            this.view_3TableAdapter.ClearBeforeFill = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // tchkplaceDataGridViewTextBoxColumn
            // 
            this.tchkplaceDataGridViewTextBoxColumn.DataPropertyName = "tchk_place";
            this.tchkplaceDataGridViewTextBoxColumn.HeaderText = "tchk_place";
            this.tchkplaceDataGridViewTextBoxColumn.Name = "tchkplaceDataGridViewTextBoxColumn";
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 352);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_1";
            this.Text = "Form_1";
            this.Load += new System.EventHandler(this.Form_1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSet_views)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private var5sqlDataSet_views var5sqlDataSet_views;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private var5sqlDataSet_viewsTableAdapters.view_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMPRISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCHKNAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private var5sqlDataSet_viewsTableAdapters.view_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource view3BindingSource;
        private var5sqlDataSet_viewsTableAdapters.view_3TableAdapter view_3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchkplaceDataGridViewTextBoxColumn;
    }
}
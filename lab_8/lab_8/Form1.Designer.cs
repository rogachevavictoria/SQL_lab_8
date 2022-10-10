namespace _8
{
    partial class Form1
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
            this.var5sqlDataSet = new _8.var5sqlDataSet();
            this.iNSPECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNSPECTTableAdapter = new _8.var5sqlDataSetTableAdapters.INSPECTTableAdapter();
            this.tableAdapterManager = new _8.var5sqlDataSetTableAdapters.TableAdapterManager();
            this.var5sqlDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.var5sqlDataSet1 = new _8.var5sqlDataSet1();
            this.view_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new _8.var5sqlDataSet1TableAdapters.view_1TableAdapter();
            this.tableAdapterManager1 = new _8.var5sqlDataSet1TableAdapters.TableAdapterManager();
            this.view_1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_2TableAdapter = new _8.var5sqlDataSet1TableAdapters.view_2TableAdapter();
            this.view_2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_2DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSPECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // var5sqlDataSet
            // 
            this.var5sqlDataSet.DataSetName = "var5sqlDataSet";
            this.var5sqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNSPECTBindingSource
            // 
            this.iNSPECTBindingSource.DataMember = "INSPECT";
            this.iNSPECTBindingSource.DataSource = this.var5sqlDataSet;
            // 
            // iNSPECTTableAdapter
            // 
            this.iNSPECTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALLSTRTableAdapter = null;
            this.tableAdapterManager.appliancesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cablesTableAdapter = null;
            this.tableAdapterManager.cabsectionsTableAdapter = null;
            this.tableAdapterManager.codetarifTableAdapter = null;
            this.tableAdapterManager.distrib_punktsTableAdapter = null;
            this.tableAdapterManager.F1031TableAdapter = null;
            this.tableAdapterManager.F104TableAdapter = null;
            this.tableAdapterManager.F107TableAdapter = null;
            this.tableAdapterManager.F108TableAdapter = null;
            this.tableAdapterManager.F109TableAdapter = null;
            this.tableAdapterManager.f115TableAdapter = null;
            this.tableAdapterManager.INSPECTTableAdapter = this.iNSPECTTableAdapter;
            this.tableAdapterManager.lenmonTableAdapter = null;
            this.tableAdapterManager.linesTableAdapter = null;
            this.tableAdapterManager.mountingTableAdapter = null;
            this.tableAdapterManager.mutualsetTableAdapter = null;
            this.tableAdapterManager.PECHPRL1TableAdapter = null;
            this.tableAdapterManager.PECHPRL2TableAdapter = null;
            this.tableAdapterManager.PECHPRL3TableAdapter = null;
            this.tableAdapterManager.printvariantTableAdapter = null;
            this.tableAdapterManager.registrTableAdapter = null;
            this.tableAdapterManager.resistanceTableAdapter = null;
            this.tableAdapterManager.sh_contenceTableAdapter = null;
            this.tableAdapterManager.SHAPKATableAdapter = null;
            this.tableAdapterManager.splintsTableAdapter = null;
            this.tableAdapterManager.SPRAVKATableAdapter = null;
            this.tableAdapterManager.std_tchkTableAdapter = null;
            this.tableAdapterManager.substationsTableAdapter = null;
            this.tableAdapterManager.TOWNSTableAdapter = null;
            this.tableAdapterManager.transcurrentTableAdapter = null;
            this.tableAdapterManager.transformersTableAdapter = null;
            this.tableAdapterManager.transpotentialTableAdapter = null;
            this.tableAdapterManager.trolleys107TableAdapter = null;
            this.tableAdapterManager.trolleys115TableAdapter = null;
            this.tableAdapterManager.tru1TableAdapter = null;
            this.tableAdapterManager.trunitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _8.var5sqlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // var5sqlDataSetBindingSource
            // 
            this.var5sqlDataSetBindingSource.DataSource = this.var5sqlDataSet;
            this.var5sqlDataSetBindingSource.Position = 0;
            // 
            // var5sqlDataSet1
            // 
            this.var5sqlDataSet1.DataSetName = "var5sqlDataSet1";
            this.var5sqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_1BindingSource
            // 
            this.view_1BindingSource.DataMember = "view_1";
            this.view_1BindingSource.DataSource = this.var5sqlDataSet1;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = _8.var5sqlDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_1DataGridView
            // 
            this.view_1DataGridView.AutoGenerateColumns = false;
            this.view_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_1DataGridView.DataSource = this.view_1BindingSource;
            this.view_1DataGridView.Location = new System.Drawing.Point(12, 12);
            this.view_1DataGridView.Name = "view_1DataGridView";
            this.view_1DataGridView.RowTemplate.Height = 28;
            this.view_1DataGridView.Size = new System.Drawing.Size(455, 426);
            this.view_1DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TCHK_NAM";
            this.dataGridViewTextBoxColumn1.HeaderText = "TCHK_NAM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TCHK";
            this.dataGridViewTextBoxColumn2.HeaderText = "TCHK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "INSPECTOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "INSPECTOR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ABON_NAM";
            this.dataGridViewTextBoxColumn4.HeaderText = "ABON_NAM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // view_2BindingSource
            // 
            this.view_2BindingSource.DataSource = this.var5sqlDataSet1;
            this.view_2BindingSource.Position = 0;
            this.view_2BindingSource.CurrentChanged += new System.EventHandler(this.view_2BindingSource_CurrentChanged);
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // view_2BindingSource1
            // 
            this.view_2BindingSource1.DataSource = this.var5sqlDataSet1;
            this.view_2BindingSource1.Position = 0;
            // 
            // view_2DataGridView
            // 
            this.view_2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_2DataGridView.Location = new System.Drawing.Point(498, 12);
            this.view_2DataGridView.Name = "view_2DataGridView";
            this.view_2DataGridView.RowTemplate.Height = 28;
            this.view_2DataGridView.Size = new System.Drawing.Size(581, 426);
            this.view_2DataGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 504);
            this.Controls.Add(this.view_2DataGridView);
            this.Controls.Add(this.view_1DataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNSPECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.var5sqlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private var5sqlDataSet var5sqlDataSet;
        private System.Windows.Forms.BindingSource iNSPECTBindingSource;
        private var5sqlDataSetTableAdapters.INSPECTTableAdapter iNSPECTTableAdapter;
        private var5sqlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource var5sqlDataSetBindingSource;
        private var5sqlDataSet1 var5sqlDataSet1;
        private System.Windows.Forms.BindingSource view_1BindingSource;
        private var5sqlDataSet1TableAdapters.view_1TableAdapter view_1TableAdapter;
        private var5sqlDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView view_1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource view_2BindingSource;
        private var5sqlDataSet1TableAdapters.view_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.BindingSource view_2BindingSource1;
        private System.Windows.Forms.DataGridView view_2DataGridView;
    }
}


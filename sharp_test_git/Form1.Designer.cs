namespace sharp_test_git
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zvs_t_blankDataSet = new sharp_test_git.zvs_t_blankDataSet();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TablesTableAdapter = new sharp_test_git.zvs_t_blankDataSetTableAdapters._TablesTableAdapter();
            this.objectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveHistoryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isTreeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.selectOnlyChildDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lineInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needPrepareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prepareSQLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagNeedClearDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useDelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idFieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIDFieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.migrationStyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoHeightDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.defaultRegisterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveStateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lineRightFilterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineRightEditIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveConfirmsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.confirmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvs_t_blankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectidDataGridViewTextBoxColumn,
            this.haveHistoryDataGridViewCheckBoxColumn,
            this.isTreeDataGridViewCheckBoxColumn,
            this.selectOnlyChildDataGridViewCheckBoxColumn,
            this.lineInfoDataGridViewTextBoxColumn,
            this.needPrepareDataGridViewCheckBoxColumn,
            this.prepareSQLDataGridViewTextBoxColumn,
            this.flagNeedClearDataGridViewCheckBoxColumn,
            this.useDelDataGridViewCheckBoxColumn,
            this.idFieldNameDataGridViewTextBoxColumn,
            this.parentIDFieldNameDataGridViewTextBoxColumn,
            this.migrationStyleDataGridViewTextBoxColumn,
            this.autoHeightDataGridViewCheckBoxColumn,
            this.defaultRegisterIDDataGridViewTextBoxColumn,
            this.haveStateDataGridViewCheckBoxColumn,
            this.lineRightFilterIDDataGridViewTextBoxColumn,
            this.lineRightEditIDDataGridViewTextBoxColumn,
            this.haveConfirmsDataGridViewCheckBoxColumn,
            this.confirmNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(386, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // zvs_t_blankDataSet
            // 
            this.zvs_t_blankDataSet.DataSetName = "zvs_t_blankDataSet";
            this.zvs_t_blankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataMember = "_Tables";
            this.tablesBindingSource.DataSource = this.zvs_t_blankDataSet;
            // 
            // _TablesTableAdapter
            // 
            this._TablesTableAdapter.ClearBeforeFill = true;
            // 
            // objectidDataGridViewTextBoxColumn
            // 
            this.objectidDataGridViewTextBoxColumn.DataPropertyName = "object_id";
            this.objectidDataGridViewTextBoxColumn.HeaderText = "object_id";
            this.objectidDataGridViewTextBoxColumn.Name = "objectidDataGridViewTextBoxColumn";
            this.objectidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // haveHistoryDataGridViewCheckBoxColumn
            // 
            this.haveHistoryDataGridViewCheckBoxColumn.DataPropertyName = "HaveHistory";
            this.haveHistoryDataGridViewCheckBoxColumn.HeaderText = "HaveHistory";
            this.haveHistoryDataGridViewCheckBoxColumn.Name = "haveHistoryDataGridViewCheckBoxColumn";
            this.haveHistoryDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isTreeDataGridViewCheckBoxColumn
            // 
            this.isTreeDataGridViewCheckBoxColumn.DataPropertyName = "isTree";
            this.isTreeDataGridViewCheckBoxColumn.HeaderText = "isTree";
            this.isTreeDataGridViewCheckBoxColumn.Name = "isTreeDataGridViewCheckBoxColumn";
            this.isTreeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // selectOnlyChildDataGridViewCheckBoxColumn
            // 
            this.selectOnlyChildDataGridViewCheckBoxColumn.DataPropertyName = "SelectOnlyChild";
            this.selectOnlyChildDataGridViewCheckBoxColumn.HeaderText = "SelectOnlyChild";
            this.selectOnlyChildDataGridViewCheckBoxColumn.Name = "selectOnlyChildDataGridViewCheckBoxColumn";
            this.selectOnlyChildDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lineInfoDataGridViewTextBoxColumn
            // 
            this.lineInfoDataGridViewTextBoxColumn.DataPropertyName = "LineInfo";
            this.lineInfoDataGridViewTextBoxColumn.HeaderText = "LineInfo";
            this.lineInfoDataGridViewTextBoxColumn.Name = "lineInfoDataGridViewTextBoxColumn";
            this.lineInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // needPrepareDataGridViewCheckBoxColumn
            // 
            this.needPrepareDataGridViewCheckBoxColumn.DataPropertyName = "NeedPrepare";
            this.needPrepareDataGridViewCheckBoxColumn.HeaderText = "NeedPrepare";
            this.needPrepareDataGridViewCheckBoxColumn.Name = "needPrepareDataGridViewCheckBoxColumn";
            this.needPrepareDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // prepareSQLDataGridViewTextBoxColumn
            // 
            this.prepareSQLDataGridViewTextBoxColumn.DataPropertyName = "PrepareSQL";
            this.prepareSQLDataGridViewTextBoxColumn.HeaderText = "PrepareSQL";
            this.prepareSQLDataGridViewTextBoxColumn.Name = "prepareSQLDataGridViewTextBoxColumn";
            this.prepareSQLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flagNeedClearDataGridViewCheckBoxColumn
            // 
            this.flagNeedClearDataGridViewCheckBoxColumn.DataPropertyName = "FlagNeedClear";
            this.flagNeedClearDataGridViewCheckBoxColumn.HeaderText = "FlagNeedClear";
            this.flagNeedClearDataGridViewCheckBoxColumn.Name = "flagNeedClearDataGridViewCheckBoxColumn";
            this.flagNeedClearDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // useDelDataGridViewCheckBoxColumn
            // 
            this.useDelDataGridViewCheckBoxColumn.DataPropertyName = "UseDel";
            this.useDelDataGridViewCheckBoxColumn.HeaderText = "UseDel";
            this.useDelDataGridViewCheckBoxColumn.Name = "useDelDataGridViewCheckBoxColumn";
            this.useDelDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idFieldNameDataGridViewTextBoxColumn
            // 
            this.idFieldNameDataGridViewTextBoxColumn.DataPropertyName = "idFieldName";
            this.idFieldNameDataGridViewTextBoxColumn.HeaderText = "idFieldName";
            this.idFieldNameDataGridViewTextBoxColumn.Name = "idFieldNameDataGridViewTextBoxColumn";
            this.idFieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentIDFieldNameDataGridViewTextBoxColumn
            // 
            this.parentIDFieldNameDataGridViewTextBoxColumn.DataPropertyName = "ParentIDFieldName";
            this.parentIDFieldNameDataGridViewTextBoxColumn.HeaderText = "ParentIDFieldName";
            this.parentIDFieldNameDataGridViewTextBoxColumn.Name = "parentIDFieldNameDataGridViewTextBoxColumn";
            this.parentIDFieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // migrationStyleDataGridViewTextBoxColumn
            // 
            this.migrationStyleDataGridViewTextBoxColumn.DataPropertyName = "MigrationStyle";
            this.migrationStyleDataGridViewTextBoxColumn.HeaderText = "MigrationStyle";
            this.migrationStyleDataGridViewTextBoxColumn.Name = "migrationStyleDataGridViewTextBoxColumn";
            this.migrationStyleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoHeightDataGridViewCheckBoxColumn
            // 
            this.autoHeightDataGridViewCheckBoxColumn.DataPropertyName = "AutoHeight";
            this.autoHeightDataGridViewCheckBoxColumn.HeaderText = "AutoHeight";
            this.autoHeightDataGridViewCheckBoxColumn.Name = "autoHeightDataGridViewCheckBoxColumn";
            this.autoHeightDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // defaultRegisterIDDataGridViewTextBoxColumn
            // 
            this.defaultRegisterIDDataGridViewTextBoxColumn.DataPropertyName = "DefaultRegister_ID";
            this.defaultRegisterIDDataGridViewTextBoxColumn.HeaderText = "DefaultRegister_ID";
            this.defaultRegisterIDDataGridViewTextBoxColumn.Name = "defaultRegisterIDDataGridViewTextBoxColumn";
            this.defaultRegisterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // haveStateDataGridViewCheckBoxColumn
            // 
            this.haveStateDataGridViewCheckBoxColumn.DataPropertyName = "HaveState";
            this.haveStateDataGridViewCheckBoxColumn.HeaderText = "HaveState";
            this.haveStateDataGridViewCheckBoxColumn.Name = "haveStateDataGridViewCheckBoxColumn";
            this.haveStateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lineRightFilterIDDataGridViewTextBoxColumn
            // 
            this.lineRightFilterIDDataGridViewTextBoxColumn.DataPropertyName = "LineRightFilter_ID";
            this.lineRightFilterIDDataGridViewTextBoxColumn.HeaderText = "LineRightFilter_ID";
            this.lineRightFilterIDDataGridViewTextBoxColumn.Name = "lineRightFilterIDDataGridViewTextBoxColumn";
            this.lineRightFilterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineRightEditIDDataGridViewTextBoxColumn
            // 
            this.lineRightEditIDDataGridViewTextBoxColumn.DataPropertyName = "LineRightEdit_ID";
            this.lineRightEditIDDataGridViewTextBoxColumn.HeaderText = "LineRightEdit_ID";
            this.lineRightEditIDDataGridViewTextBoxColumn.Name = "lineRightEditIDDataGridViewTextBoxColumn";
            this.lineRightEditIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // haveConfirmsDataGridViewCheckBoxColumn
            // 
            this.haveConfirmsDataGridViewCheckBoxColumn.DataPropertyName = "HaveConfirms";
            this.haveConfirmsDataGridViewCheckBoxColumn.HeaderText = "HaveConfirms";
            this.haveConfirmsDataGridViewCheckBoxColumn.Name = "haveConfirmsDataGridViewCheckBoxColumn";
            this.haveConfirmsDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // confirmNameDataGridViewTextBoxColumn
            // 
            this.confirmNameDataGridViewTextBoxColumn.DataPropertyName = "ConfirmName";
            this.confirmNameDataGridViewTextBoxColumn.HeaderText = "ConfirmName";
            this.confirmNameDataGridViewTextBoxColumn.Name = "confirmNameDataGridViewTextBoxColumn";
            this.confirmNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 245);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zvs_t_blankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private zvs_t_blankDataSet zvs_t_blankDataSet;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private zvs_t_blankDataSetTableAdapters._TablesTableAdapter _TablesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn haveHistoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isTreeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectOnlyChildDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needPrepareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepareSQLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flagNeedClearDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useDelDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDFieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn migrationStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoHeightDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultRegisterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn haveStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineRightFilterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineRightEditIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn haveConfirmsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmNameDataGridViewTextBoxColumn;
    }
}


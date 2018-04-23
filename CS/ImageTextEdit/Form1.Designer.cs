namespace ImageTextEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.customGridControl1 = new ImageTextEdit.CustomGridControl();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new ImageTextEdit.nwindDataSet();
            this.customAdvGridView1 = new ImageTextEdit.CustomAdvGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCustomerID2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCompanyName2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactTitle2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactName2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCustomIconTextEdit1 = new ImageTextEdit.RepositoryItemCustomIconTextEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCity2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCountry2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.customGridView2 = new ImageTextEdit.CustomGridView();
            this.colCustomerID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customGridView1 = new ImageTextEdit.CustomGridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customersTableAdapter = new ImageTextEdit.nwindDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customAdvGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomIconTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(24, 24);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Basket.png");
            this.imageCollection1.Images.SetKeyName(1, "Check.png");
            this.imageCollection1.Images.SetKeyName(2, "Customer.png");
            this.imageCollection1.Images.SetKeyName(3, "Folder.png");
            this.imageCollection1.Images.SetKeyName(4, "Home.png");
            this.imageCollection1.Images.SetKeyName(5, "Key.png");
            this.imageCollection1.Images.SetKeyName(6, "Mail.png");
            this.imageCollection1.Images.SetKeyName(7, "Printing.png");
            this.imageCollection1.Images.SetKeyName(8, "Product.png");
            this.imageCollection1.Images.SetKeyName(9, "Products.png");
            this.imageCollection1.Images.SetKeyName(10, "Report.png");
            this.imageCollection1.Images.SetKeyName(11, "Scheduller.png");
            this.imageCollection1.Images.SetKeyName(12, "Security Folder.png");
            this.imageCollection1.Images.SetKeyName(13, "Task.png");
            this.imageCollection1.Images.SetKeyName(14, "User Folder.png");
            this.imageCollection1.Images.SetKeyName(15, "User.png");
            this.imageCollection1.Images.SetKeyName(16, "UserKey.png");
            // 
            // customGridControl1
            // 
            this.customGridControl1.DataSource = this.customersBindingSource;
            this.customGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridControl1.Location = new System.Drawing.Point(0, 0);
            this.customGridControl1.MainView = this.customAdvGridView1;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCustomIconTextEdit1});
            this.customGridControl1.Size = new System.Drawing.Size(808, 450);
            this.customGridControl1.TabIndex = 0;
            this.customGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView2,
            this.customGridView1,
            this.customAdvGridView1});
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customAdvGridView1
            // 
            this.customAdvGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.customAdvGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colCustomerID2,
            this.colCompanyName2,
            this.colContactName2,
            this.colContactTitle2,
            this.colCity2,
            this.colCountry2});
            this.customAdvGridView1.GridControl = this.customGridControl1;
            this.customAdvGridView1.Name = "customAdvGridView1";
            this.customAdvGridView1.OnSmartIconSelection += new ImageTextEdit.OnSmartIconSelectionEventHandler(this.customGridView1_OnSmartIconSelection);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colCustomerID2);
            this.gridBand1.Columns.Add(this.colCompanyName2);
            this.gridBand1.Columns.Add(this.colContactTitle2);
            this.gridBand1.Columns.Add(this.colContactName2);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 238;
            // 
            // colCustomerID2
            // 
            this.colCustomerID2.FieldName = "CustomerID";
            this.colCustomerID2.Name = "colCustomerID2";
            this.colCustomerID2.Visible = true;
            // 
            // colCompanyName2
            // 
            this.colCompanyName2.FieldName = "CompanyName";
            this.colCompanyName2.Name = "colCompanyName2";
            this.colCompanyName2.Visible = true;
            this.colCompanyName2.Width = 88;
            // 
            // colContactTitle2
            // 
            this.colContactTitle2.FieldName = "ContactTitle";
            this.colContactTitle2.Name = "colContactTitle2";
            this.colContactTitle2.Visible = true;
            // 
            // colContactName2
            // 
            this.colContactName2.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colContactName2.FieldName = "ContactName";
            this.colContactName2.Name = "colContactName2";
            this.colContactName2.RowIndex = 1;
            this.colContactName2.Visible = true;
            this.colContactName2.Width = 238;
            // 
            // repositoryItemCustomIconTextEdit1
            // 
            this.repositoryItemCustomIconTextEdit1.AutoHeight = false;
            this.repositoryItemCustomIconTextEdit1.ImageList = this.imageCollection1;
            this.repositoryItemCustomIconTextEdit1.Name = "repositoryItemCustomIconTextEdit1";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.colCity2);
            this.gridBand2.Columns.Add(this.colCountry2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 206;
            // 
            // colCity2
            // 
            this.colCity2.AutoFillDown = true;
            this.colCity2.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colCity2.FieldName = "City";
            this.colCity2.Name = "colCity2";
            this.colCity2.Visible = true;
            this.colCity2.Width = 116;
            // 
            // colCountry2
            // 
            this.colCountry2.AutoFillDown = true;
            this.colCountry2.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colCountry2.FieldName = "Country";
            this.colCountry2.Name = "colCountry2";
            this.colCountry2.Visible = true;
            this.colCountry2.Width = 90;
            // 
            // customGridView2
            // 
            this.customGridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID1,
            this.colCompanyName1,
            this.colContactName1,
            this.colContactTitle1,
            this.colCity1,
            this.colCountry1});
            this.customGridView2.GridControl = this.customGridControl1;
            this.customGridView2.Name = "customGridView2";
            this.customGridView2.OnSmartIconSelection += new ImageTextEdit.OnSmartIconSelectionEventHandler(this.customGridView1_OnSmartIconSelection);
            // 
            // colCustomerID1
            // 
            this.colCustomerID1.FieldName = "CustomerID";
            this.colCustomerID1.Name = "colCustomerID1";
            this.colCustomerID1.Visible = true;
            this.colCustomerID1.VisibleIndex = 0;
            // 
            // colCompanyName1
            // 
            this.colCompanyName1.FieldName = "CompanyName";
            this.colCompanyName1.Name = "colCompanyName1";
            this.colCompanyName1.Visible = true;
            this.colCompanyName1.VisibleIndex = 1;
            // 
            // colContactName1
            // 
            this.colContactName1.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colContactName1.FieldName = "ContactName";
            this.colContactName1.Name = "colContactName1";
            this.colContactName1.Visible = true;
            this.colContactName1.VisibleIndex = 2;
            // 
            // colContactTitle1
            // 
            this.colContactTitle1.FieldName = "ContactTitle";
            this.colContactTitle1.Name = "colContactTitle1";
            this.colContactTitle1.Visible = true;
            this.colContactTitle1.VisibleIndex = 3;
            // 
            // colCity1
            // 
            this.colCity1.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colCity1.FieldName = "City";
            this.colCity1.Name = "colCity1";
            this.colCity1.Visible = true;
            this.colCity1.VisibleIndex = 4;
            // 
            // colCountry1
            // 
            this.colCountry1.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colCountry1.FieldName = "Country";
            this.colCountry1.Name = "colCountry1";
            this.colCountry1.Visible = true;
            this.colCountry1.VisibleIndex = 5;
            // 
            // customGridView1
            // 
            this.customGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colCity,
            this.colCountry});
            this.customGridView1.GridControl = this.customGridControl1;
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.OnSmartIconSelection += new ImageTextEdit.OnSmartIconSelectionEventHandler(this.customGridView1_OnSmartIconSelection);
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            // 
            // colContactName
            // 
            this.colContactName.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 2;
            // 
            // colContactTitle
            // 
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.Visible = true;
            this.colContactTitle.VisibleIndex = 3;
            // 
            // colCity
            // 
            this.colCity.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            // 
            // colCountry
            // 
            this.colCountry.ColumnEdit = this.repositoryItemCustomIconTextEdit1;
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 5;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.customGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customAdvGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomIconTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private CustomGridControl customGridControl1;
        private CustomGridView customGridView1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ImageTextEdit.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private RepositoryItemCustomIconTextEdit repositoryItemCustomIconTextEdit1;
        private CustomGridView customGridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName1;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName1;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colCity1;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry1;
        private CustomAdvGridView customAdvGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomerID2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompanyName2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactName2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactTitle2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCountry2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;

    }
}


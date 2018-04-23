Imports Microsoft.VisualBasic
Imports System
Namespace ImageTextEdit
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.customGridControl1 = New ImageTextEdit.CustomGridControl()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New ImageTextEdit.nwindDataSet()
			Me.customAdvGridView1 = New ImageTextEdit.CustomAdvGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCustomerID2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCompanyName2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colContactTitle2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colContactName2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemCustomIconTextEdit1 = New ImageTextEdit.RepositoryItemCustomIconTextEdit()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCity2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCountry2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.customGridView2 = New ImageTextEdit.CustomGridView()
			Me.colCustomerID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.customGridView1 = New ImageTextEdit.CustomGridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.customersTableAdapter = New ImageTextEdit.nwindDataSetTableAdapters.CustomersTableAdapter()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customAdvGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCustomIconTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(24, 24)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Basket.png")
			Me.imageCollection1.Images.SetKeyName(1, "Check.png")
			Me.imageCollection1.Images.SetKeyName(2, "Customer.png")
			Me.imageCollection1.Images.SetKeyName(3, "Folder.png")
			Me.imageCollection1.Images.SetKeyName(4, "Home.png")
			Me.imageCollection1.Images.SetKeyName(5, "Key.png")
			Me.imageCollection1.Images.SetKeyName(6, "Mail.png")
			Me.imageCollection1.Images.SetKeyName(7, "Printing.png")
			Me.imageCollection1.Images.SetKeyName(8, "Product.png")
			Me.imageCollection1.Images.SetKeyName(9, "Products.png")
			Me.imageCollection1.Images.SetKeyName(10, "Report.png")
			Me.imageCollection1.Images.SetKeyName(11, "Scheduller.png")
			Me.imageCollection1.Images.SetKeyName(12, "Security Folder.png")
			Me.imageCollection1.Images.SetKeyName(13, "Task.png")
			Me.imageCollection1.Images.SetKeyName(14, "User Folder.png")
			Me.imageCollection1.Images.SetKeyName(15, "User.png")
			Me.imageCollection1.Images.SetKeyName(16, "UserKey.png")
			' 
			' customGridControl1
			' 
			Me.customGridControl1.DataSource = Me.customersBindingSource
			Me.customGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.customGridControl1.MainView = Me.customAdvGridView1
			Me.customGridControl1.Name = "customGridControl1"
			Me.customGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCustomIconTextEdit1})
			Me.customGridControl1.Size = New System.Drawing.Size(808, 450)
			Me.customGridControl1.TabIndex = 0
			Me.customGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.customGridView2, Me.customGridView1, Me.customAdvGridView1})
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customAdvGridView1
			' 
			Me.customAdvGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.customAdvGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colCustomerID2, Me.colCompanyName2, Me.colContactName2, Me.colContactTitle2, Me.colCity2, Me.colCountry2})
			Me.customAdvGridView1.GridControl = Me.customGridControl1
			Me.customAdvGridView1.Name = "customAdvGridView1"
'			Me.customAdvGridView1.OnSmartIconSelection += New ImageTextEdit.OnSmartIconSelectionEventHandler(Me.customGridView1_OnSmartIconSelection);
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.colCustomerID2)
			Me.gridBand1.Columns.Add(Me.colCompanyName2)
			Me.gridBand1.Columns.Add(Me.colContactTitle2)
			Me.gridBand1.Columns.Add(Me.colContactName2)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 238
			' 
			' colCustomerID2
			' 
			Me.colCustomerID2.FieldName = "CustomerID"
			Me.colCustomerID2.Name = "colCustomerID2"
			Me.colCustomerID2.Visible = True
			' 
			' colCompanyName2
			' 
			Me.colCompanyName2.FieldName = "CompanyName"
			Me.colCompanyName2.Name = "colCompanyName2"
			Me.colCompanyName2.Visible = True
			Me.colCompanyName2.Width = 88
			' 
			' colContactTitle2
			' 
			Me.colContactTitle2.FieldName = "ContactTitle"
			Me.colContactTitle2.Name = "colContactTitle2"
			Me.colContactTitle2.Visible = True
			' 
			' colContactName2
			' 
			Me.colContactName2.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colContactName2.FieldName = "ContactName"
			Me.colContactName2.Name = "colContactName2"
			Me.colContactName2.RowIndex = 1
			Me.colContactName2.Visible = True
			Me.colContactName2.Width = 238
			' 
			' repositoryItemCustomIconTextEdit1
			' 
			Me.repositoryItemCustomIconTextEdit1.AutoHeight = False
			Me.repositoryItemCustomIconTextEdit1.ImageList = Me.imageCollection1
			Me.repositoryItemCustomIconTextEdit1.Name = "repositoryItemCustomIconTextEdit1"
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Columns.Add(Me.colCity2)
			Me.gridBand2.Columns.Add(Me.colCountry2)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 206
			' 
			' colCity2
			' 
			Me.colCity2.AutoFillDown = True
			Me.colCity2.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colCity2.FieldName = "City"
			Me.colCity2.Name = "colCity2"
			Me.colCity2.Visible = True
			Me.colCity2.Width = 116
			' 
			' colCountry2
			' 
			Me.colCountry2.AutoFillDown = True
			Me.colCountry2.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colCountry2.FieldName = "Country"
			Me.colCountry2.Name = "colCountry2"
			Me.colCountry2.Visible = True
			Me.colCountry2.Width = 90
			' 
			' customGridView2
			' 
			Me.customGridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID1, Me.colCompanyName1, Me.colContactName1, Me.colContactTitle1, Me.colCity1, Me.colCountry1})
			Me.customGridView2.GridControl = Me.customGridControl1
			Me.customGridView2.Name = "customGridView2"
'			Me.customGridView2.OnSmartIconSelection += New ImageTextEdit.OnSmartIconSelectionEventHandler(Me.customGridView1_OnSmartIconSelection);
			' 
			' colCustomerID1
			' 
			Me.colCustomerID1.FieldName = "CustomerID"
			Me.colCustomerID1.Name = "colCustomerID1"
			Me.colCustomerID1.Visible = True
			Me.colCustomerID1.VisibleIndex = 0
			' 
			' colCompanyName1
			' 
			Me.colCompanyName1.FieldName = "CompanyName"
			Me.colCompanyName1.Name = "colCompanyName1"
			Me.colCompanyName1.Visible = True
			Me.colCompanyName1.VisibleIndex = 1
			' 
			' colContactName1
			' 
			Me.colContactName1.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colContactName1.FieldName = "ContactName"
			Me.colContactName1.Name = "colContactName1"
			Me.colContactName1.Visible = True
			Me.colContactName1.VisibleIndex = 2
			' 
			' colContactTitle1
			' 
			Me.colContactTitle1.FieldName = "ContactTitle"
			Me.colContactTitle1.Name = "colContactTitle1"
			Me.colContactTitle1.Visible = True
			Me.colContactTitle1.VisibleIndex = 3
			' 
			' colCity1
			' 
			Me.colCity1.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colCity1.FieldName = "City"
			Me.colCity1.Name = "colCity1"
			Me.colCity1.Visible = True
			Me.colCity1.VisibleIndex = 4
			' 
			' colCountry1
			' 
			Me.colCountry1.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colCountry1.FieldName = "Country"
			Me.colCountry1.Name = "colCountry1"
			Me.colCountry1.Visible = True
			Me.colCountry1.VisibleIndex = 5
			' 
			' customGridView1
			' 
			Me.customGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colCity, Me.colCountry})
			Me.customGridView1.GridControl = Me.customGridControl1
			Me.customGridView1.Name = "customGridView1"
'			Me.customGridView1.OnSmartIconSelection += New ImageTextEdit.OnSmartIconSelectionEventHandler(Me.customGridView1_OnSmartIconSelection);
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colCompanyName
			' 
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Visible = True
			Me.colCompanyName.VisibleIndex = 1
			' 
			' colContactName
			' 
			Me.colContactName.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.VisibleIndex = 2
			' 
			' colContactTitle
			' 
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			Me.colContactTitle.Visible = True
			Me.colContactTitle.VisibleIndex = 3
			' 
			' colCity
			' 
			Me.colCity.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 4
			' 
			' colCountry
			' 
			Me.colCountry.ColumnEdit = Me.repositoryItemCustomIconTextEdit1
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 5
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(808, 450)
			Me.Controls.Add(Me.customGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customAdvGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCustomIconTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private customGridControl1 As CustomGridControl
		Private WithEvents customGridView1 As CustomGridView
		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As ImageTextEdit.nwindDataSetTableAdapters.CustomersTableAdapter
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemCustomIconTextEdit1 As RepositoryItemCustomIconTextEdit
		Private WithEvents customGridView2 As CustomGridView
		Private colCustomerID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents customAdvGridView1 As CustomAdvGridView
		Private colCustomerID2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCompanyName2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colContactName2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colContactTitle2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCity2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCountry2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

	End Class
End Namespace


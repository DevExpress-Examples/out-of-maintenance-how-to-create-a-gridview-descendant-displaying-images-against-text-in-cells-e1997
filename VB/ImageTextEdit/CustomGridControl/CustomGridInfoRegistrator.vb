Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Namespace ImageTextEdit
	Public Class CustomGridInfoRegistrator
		Inherits GridInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides Function CreatePainter(ByVal view As BaseView) As BaseViewPainter
			Return New CustomGridPainter(TryCast(view, CustomGridView))
		End Function
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New CustomGridView(grid)
		End Function
	End Class
	Public Class CustomAdvGridInfoRegistrator
		Inherits AdvBandedGridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomAdvGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New CustomAdvGridView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreatePainter(ByVal view As BaseView) As BaseViewPainter
			Return New CustomAdvGridPainter(TryCast(view, CustomAdvGridView))
		End Function
	End Class


	'public class MyGridViewInfoRegistrator : GridInfoRegistrator
	'{
	'    public override string ViewName { get { return "MyGridView"; } }
	'    public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
	'    public override BaseViewPainter CreatePainter(BaseView view) { return new MyGridPainter(view as MyGridView); }
	'}
	'public class MyBandedGridViewInfoRegistrator : BandedGridInfoRegistrator
	'{
	'    public override string ViewName { get { return "MyBandedGridView"; } }
	'    public override BaseView CreateView(GridControl grid) { return new MyBandedGridView(grid as GridControl); }
	'    public override BaseViewPainter CreatePainter(BaseView view) { return new MyBandedGridPainter(view as MyBandedGridView); }
	'}


End Namespace

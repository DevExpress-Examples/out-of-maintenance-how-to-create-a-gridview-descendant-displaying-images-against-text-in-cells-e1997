Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.BandedGrid.Drawing
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace ImageTextEdit
	Public Class CustomAdvGridPainter
		Inherits AdvBandedGridPainter
		Private nowDrawingCellInfo As GridCellInfo
		Public Sub New(ByVal view As AdvBandedGridView)
			MyBase.New(view)
		End Sub

		Public Overridable Shadows ReadOnly Property View() As CustomAdvGridView
			Get
				Return CType(MyBase.View, CustomAdvGridView)
			End Get
		End Property
		Protected Overrides Sub DrawCellEdit(ByVal e As GridViewDrawArgs, ByVal editInfo As BaseEditViewInfo, ByVal cell As GridCellInfo, ByVal appearance As AppearanceObject, ByVal isSelectedCell As Boolean)
			Dim iconSelector As IIconSelector = TryCast(cell.Editor, IIconSelector)
			If iconSelector IsNot Nothing Then
				Dim EH As New OnIconSelectionEventHandler(AddressOf iconSelector_OnIconSelection)
				AddHandler iconSelector.OnIconSelection, EH
				nowDrawingCellInfo = cell
				Try
					MyBase.DrawCellEdit(e, editInfo, cell, appearance, isSelectedCell)
				Finally
					RemoveHandler iconSelector.OnIconSelection, EH
				End Try
			Else
				MyBase.DrawCellEdit(e, editInfo, cell, appearance, isSelectedCell)
			End If
		End Sub
		Private Sub iconSelector_OnIconSelection(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs)
			Dim ee As New OnSmartIconSelectionEventArgs(e.ImageList, e.ImageIndex, nowDrawingCellInfo, False)
			View.RaiseOnSmartIconSelection(ee)
			e.ImageIndex = ee.ImageIndex
		End Sub
	End Class

End Namespace

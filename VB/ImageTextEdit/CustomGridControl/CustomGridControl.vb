Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Container
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel

Namespace ImageTextEdit
	Public Class CustomGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New CustomGridInfoRegistrator())
			collection.Add(New CustomAdvGridInfoRegistrator())
		End Sub

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("CustomGridView")
		End Function
	End Class
	Public Delegate Sub OnSmartIconSelectionEventHandler(ByVal sender As Object, ByVal e As OnSmartIconSelectionEventArgs)
	Public Class OnSmartIconSelectionEventArgs
		Inherits OnIconSelectionEventArgs
		Private isActiveEditor_Renamed As Boolean
		Private cellInfo_Renamed As GridCellInfo
		Public Sub New(ByVal iconCollection As Object, ByVal iconIndex As Integer, ByVal cellInfo As GridCellInfo, ByVal isActiveEditor As Boolean)
			MyBase.New(iconCollection, iconIndex)
			Me.cellInfo_Renamed = cellInfo
			Me.isActiveEditor_Renamed = isActiveEditor
		End Sub
		Public ReadOnly Property CellInfo() As GridCellInfo
			Get
				Return cellInfo_Renamed
			End Get
		End Property
		Public ReadOnly Property IsActiveEditor() As Boolean
			Get
				Return isActiveEditor_Renamed
			End Get
		End Property
	End Class

End Namespace

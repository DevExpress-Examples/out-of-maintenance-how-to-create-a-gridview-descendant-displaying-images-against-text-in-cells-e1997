Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports System.Drawing

Namespace ImageTextEdit
	Public Class CustomIconTextEditPainter
		Inherits TextEditPainter
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			MyBase.DrawContent(info)
			DrawIcon(info)
		End Sub


		Protected Overridable Sub DrawIcon(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As CustomIconTextEditViewInfo = TryCast(info.ViewInfo, CustomIconTextEditViewInfo)
			Dim e As New OnIconSelectionEventArgs(vi.ImageList, vi.ImageIndex)
			vi.Item.RaiseOnIconSelection(e)
			If e.ImageList IsNot Nothing AndAlso e.ImageIndex <> -1 Then
				info.Cache.Paint.DrawImage(info.Cache, e.ImageList, e.ImageIndex, vi.IconRect, True)
			Else
				info.Graphics.FillRectangle(info.Cache.GetSolidBrush(Color.White), vi.IconRect)
			End If

		End Sub
	End Class

End Namespace

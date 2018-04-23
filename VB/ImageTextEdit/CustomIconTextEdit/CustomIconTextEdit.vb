Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace ImageTextEdit
	Public Class CustomIconTextEdit
		Inherits TextEdit
		Shared Sub New()
			RepositoryItemCustomIconTextEdit.RegisterCustomIconTextEdit()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomIconTextEdit.CustomIconTextEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomIconTextEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomIconTextEdit)
			End Get
		End Property

		Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim vi As CustomIconTextEditViewInfo = TryCast(ViewInfo, CustomIconTextEditViewInfo)
			If vi.IsIconClick(e.Location) Then
				Dim newX As Integer = e.X - vi.IconRect.Left
				Dim newY As Integer = e.Y - vi.IconRect.Top
				Dim ee As New MouseEventArgs(e.Button, e.Clicks, newX, newY, e.Delta)
				Properties.RaiseIconClick(ee)
			End If
			MyBase.OnMouseDown(e)
		End Sub
		Public Custom Event IconClick As IconClickEventHandler
			AddHandler(ByVal value As IconClickEventHandler)
				AddHandler Me.Properties.IconClick, value
			End AddHandler
			RemoveHandler(ByVal value As IconClickEventHandler)
				RemoveHandler Me.Properties.IconClick, value
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As MouseEventArgs)
			End RaiseEvent
		End Event
	End Class

End Namespace

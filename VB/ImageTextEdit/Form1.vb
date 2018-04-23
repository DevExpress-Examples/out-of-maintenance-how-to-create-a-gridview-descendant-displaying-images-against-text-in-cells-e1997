Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ImageTextEdit
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)
		End Sub

		Private Sub customGridView1_OnSmartIconSelection(ByVal sender As Object, ByVal e As OnSmartIconSelectionEventArgs) Handles customAdvGridView1.OnSmartIconSelection, customGridView2.OnSmartIconSelection, customGridView1.OnSmartIconSelection
			If e.CellInfo.Column.FieldName = "ContactName" Then
				If e.IsActiveEditor Then
					e.ImageIndex = 0
				Else
					e.ImageIndex = 1
				End If
			End If
			If e.CellInfo.Column.FieldName = "City" Then
				If e.IsActiveEditor Then
					e.ImageIndex = 2
				Else
					e.ImageIndex = 3
				End If
			End If
			If e.CellInfo.Column.FieldName = "Country" Then
				If e.IsActiveEditor Then
					e.ImageIndex = 4
				Else
					e.ImageIndex = 5
				End If
			End If

		End Sub
	End Class
End Namespace
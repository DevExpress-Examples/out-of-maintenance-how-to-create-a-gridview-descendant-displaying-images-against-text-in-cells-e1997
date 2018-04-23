Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports DevExpress.Utils

Namespace ImageTextEdit
	Public Class CustomIconTextEditViewInfo
		Inherits TextEditViewInfo
		Private fIconRect As Rectangle
		Private SeparatorWidth As Integer = 3

		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
			fIconRect = Rectangle.Empty
		End Sub


		Protected Friend Overridable Function IsIconClick(ByVal p As Point) As Boolean
			If p.X > IconRect.Left AndAlso p.X < IconRect.Right AndAlso p.Y > IconRect.Top AndAlso p.Y < IconRect.Bottom Then
				Return True
			Else
				Return False
			End If
		End Function

		Public ReadOnly Property ImageList() As Object
			Get
				Return Item.ImageList
			End Get
		End Property

		Public ReadOnly Property ImageIndex() As Integer
			Get
				Return Item.ImageIndex
			End Get
		End Property

		Public Overridable Shadows ReadOnly Property Item() As RepositoryItemCustomIconTextEdit
			Get
				Return TryCast(MyBase.Item, RepositoryItemCustomIconTextEdit)
			End Get
		End Property

		Protected Overrides Sub Assign(ByVal info As BaseControlViewInfo)
			MyBase.Assign(info)
			Dim be As CustomIconTextEditViewInfo = TryCast(info, CustomIconTextEditViewInfo)
			If be Is Nothing Then
				Return
			End If
			Me.fIconRect = be.fIconRect
		End Sub

		Public Overrides Function CalcBestFit(ByVal g As Graphics) As Size
			Dim s As Size = MyBase.CalcBestFit(g)
			s.Width = s.Width + SeparatorWidth * 2 + GetImageSize().Width
			Return s
		End Function

		Protected Friend Overridable Property IconRect() As Rectangle
			Get
				Return fIconRect
			End Get
			Set(ByVal value As Rectangle)
				fIconRect = value
			End Set
		End Property

		Public Overrides Sub Offset(ByVal x As Integer, ByVal y As Integer)
			MyBase.Offset(x, y)
			If (Not fIconRect.IsEmpty) Then
				Me.fIconRect.Offset(x, y)
			End If
		End Sub

		Protected Overrides Function CalcMaskBoxRect(ByVal content As Rectangle) As Rectangle
			Dim r As Rectangle = MyBase.CalcMaskBoxRect(content)
			r.Width = r.Width - GetImageSize().Width - SeparatorWidth
			Return r
		End Function

		Protected Overrides Sub CalcContentRect(ByVal bounds As Rectangle)
			MyBase.CalcContentRect(bounds)
			Me.fIconRect = CalcIconRect(ContentRect)
		End Sub

		Protected Overridable Function CalcIconRect(ByVal content As Rectangle) As Rectangle
			Dim r As Rectangle = fMaskBoxRect
			r.Size = GetImageSize()
			r.Location = New Point(fMaskBoxRect.Right + SeparatorWidth, content.Top + content.Height / 2 - r.Height / 2)
			Return r
		End Function

		Protected Function GetImageSize() As Size
			Dim ic As ImageCollection = TryCast(ImageList, ImageCollection)
			If ic IsNot Nothing Then
				Return ic.ImageSize
			End If
			Return New Size(0, 0)
		End Function

		Protected Overrides Function CalcMinHeightCore(ByVal g As Graphics) As Integer
			Dim imageHeight As Integer = 0
			If ImageList IsNot Nothing Then
				imageHeight = GetImageSize().Height
				If AllowDrawFocusRect Then
					imageHeight += (FocusRectThin + 1) * 2
				End If
			End If
			Dim fontHeight As Integer = MyBase.CalcMinHeightCore(g)
			If imageHeight > fontHeight Then
				Return imageHeight
			Else
				Return fontHeight
			End If
		End Function
	End Class

End Namespace

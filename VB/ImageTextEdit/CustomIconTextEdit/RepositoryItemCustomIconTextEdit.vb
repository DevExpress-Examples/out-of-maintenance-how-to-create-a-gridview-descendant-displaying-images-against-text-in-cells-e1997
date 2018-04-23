Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Registrator
Imports System.ComponentModel
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing

Namespace ImageTextEdit
	<UserRepositoryItem("RegisterCustomIconTextEdit")> _
	Public Class RepositoryItemCustomIconTextEdit
		Inherits RepositoryItemTextEdit
		Implements IIconSelector
		Private imageList_Renamed As Object
		Private imageIndex_Renamed As Integer

		Shared Sub New()
			RegisterCustomIconTextEdit()
		End Sub

		Public Sub New()
			imageList_Renamed = Nothing
			ImageIndex = -1
		End Sub

		Public Const CustomIconTextEditName As String = "CustomIconTextEdit"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomIconTextEditName
			End Get
		End Property

		Public Shared Sub RegisterCustomIconTextEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomIconTextEditName, GetType(CustomIconTextEdit), GetType(RepositoryItemCustomIconTextEdit), GetType(TextEditViewInfo), New TextEditPainter(), True))
		End Sub


		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			Dim source As RepositoryItemCustomIconTextEdit = TryCast(item, RepositoryItemCustomIconTextEdit)
			Events.AddHandler(_iconClick, source.Events(_iconClick))
			Events.AddHandler(_onIconSelection, source.Events(_onIconSelection))
			Me.imageList_Renamed = source.ImageList
			Me.imageIndex_Renamed = source.ImageIndex
		End Sub
		Private Shared ReadOnly _iconClick As Object = New Object()
		Private Shared ReadOnly _onIconSelection As Object = New Object()

		Public Custom Event IconClick As IconClickEventHandler
			AddHandler(ByVal value As IconClickEventHandler)
				Me.Events.AddHandler(_iconClick, value)
			End AddHandler
			RemoveHandler(ByVal value As IconClickEventHandler)
				Me.Events.RemoveHandler(_iconClick, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As MouseEventArgs)
			End RaiseEvent
		End Event
		Protected Friend Overridable Sub RaiseIconClick(ByVal e As MouseEventArgs)
			Dim handler As IconClickEventHandler = CType(Events(_iconClick), IconClickEventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), e)
			End If
		End Sub
		Friend ReadOnly Property CanRaiseBeforeEditValueLoaded() As Boolean
			Get
				Return CType(Events(_iconClick), IconClickEventHandler) IsNot Nothing
			End Get
		End Property

		Public Custom Event OnIconSelection As OnIconSelectionEventHandler Implements IIconSelector.OnIconSelection
			AddHandler(ByVal value As OnIconSelectionEventHandler)
				Me.Events.AddHandler(_onIconSelection, value)
			End AddHandler
			RemoveHandler(ByVal value As OnIconSelectionEventHandler)
				Me.Events.RemoveHandler(_onIconSelection, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs)
			End RaiseEvent
		End Event
		Protected Friend Overridable Sub RaiseOnIconSelection(ByVal e As OnIconSelectionEventArgs)
			Dim handler As OnIconSelectionEventHandler = CType(Events(_onIconSelection), OnIconSelectionEventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), e)
			End If
		End Sub


		<Description("Gets or sets the source of images to be displayed within the editor."), Category(CategoryName.Appearance), TypeConverter(GetType(DevExpress.Utils.Design.ImageCollectionImagesConverter))> _
		Public Overridable Property ImageList() As Object
			Get
				Return imageList_Renamed
			End Get
			Set(ByVal value As Object)
				If ImageList Is value Then
					Return
				End If
				imageList_Renamed = value
				OnPropertiesChanged()
			End Set
		End Property

		<Description("Gets or sets the index of the image displayed on the editor."), Category(CategoryName.Appearance), DefaultValue(-1), Editor(GetType(DevExpress.Utils.Design.ImageIndexesEditor), GetType(System.Drawing.Design.UITypeEditor)), ImageList("ImageList")> _
		Public Overridable Property ImageIndex() As Integer
			Get
				Return imageIndex_Renamed
			End Get
			Set(ByVal value As Integer)
				If ImageIndex = value Then
					Return
				End If
				imageIndex_Renamed = value
				OnPropertiesChanged()
			End Set
		End Property

		Public Overrides Function CreateViewInfo() As BaseEditViewInfo
			Return New CustomIconTextEditViewInfo(Me)
		End Function
		Public Overrides Function CreatePainter() As BaseEditPainter
			Return New CustomIconTextEditPainter()
		End Function
	End Class

	Public Delegate Sub IconClickEventHandler(ByVal sender As Object, ByVal e As MouseEventArgs)
	Public Delegate Sub OnIconSelectionEventHandler(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs)
	Public Class OnIconSelectionEventArgs
		Inherits EventArgs
		Private imageIndex_Renamed As Integer
		Private imageList_Renamed As Object
		Public Sub New(ByVal iconCollection As Object, ByVal iconIndex As Integer)
			Me.imageList_Renamed = iconCollection
			Me.imageIndex_Renamed = iconIndex
		End Sub
		Public Overridable Property ImageIndex() As Integer
			Get
				Return imageIndex_Renamed
			End Get
			Set(ByVal value As Integer)
				imageIndex_Renamed = value
			End Set
		End Property
		Public Overridable ReadOnly Property ImageList() As Object
			Get
				Return imageList_Renamed
			End Get
			'set { imageList = value; }
		End Property
	End Class
End Namespace

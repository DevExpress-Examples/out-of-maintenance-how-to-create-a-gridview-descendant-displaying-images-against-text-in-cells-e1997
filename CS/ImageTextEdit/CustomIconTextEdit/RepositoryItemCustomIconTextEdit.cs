using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;

namespace ImageTextEdit
{
    [UserRepositoryItem("RegisterCustomIconTextEdit")]
    public class RepositoryItemCustomIconTextEdit : RepositoryItemTextEdit, IIconSelector
    {
        object imageList;
        int imageIndex;

        static RepositoryItemCustomIconTextEdit() { RegisterCustomIconTextEdit(); }

        public RepositoryItemCustomIconTextEdit()
        {
            imageList = null;
            ImageIndex = -1;
        }

        public const string CustomIconTextEditName = "CustomIconTextEdit";

        public override string EditorTypeName { get { return CustomIconTextEditName; } }

        public static void RegisterCustomIconTextEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomIconTextEditName,
              typeof(CustomIconTextEdit), typeof(RepositoryItemCustomIconTextEdit),
              typeof(TextEditViewInfo), new TextEditPainter(), true));
        }


        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RepositoryItemCustomIconTextEdit source = item as RepositoryItemCustomIconTextEdit;
            Events.AddHandler(_iconClick, source.Events[_iconClick]);
            Events.AddHandler(_onIconSelection, source.Events[_onIconSelection]);
            this.imageList = source.ImageList;
            this.imageIndex = source.ImageIndex;
        }
        static readonly object _iconClick = new object();
        static readonly object _onIconSelection = new object();

        public event IconClickEventHandler IconClick
        {
            add { this.Events.AddHandler(_iconClick, value); }
            remove { this.Events.RemoveHandler(_iconClick, value); }
        }
        protected internal virtual void RaiseIconClick(MouseEventArgs e)
        {
            IconClickEventHandler handler = (IconClickEventHandler)Events[_iconClick];
            if (handler != null) handler(GetEventSender(), e);
        }
        internal bool CanRaiseBeforeEditValueLoaded { get { return (IconClickEventHandler)Events[_iconClick] != null; } }

        public event OnIconSelectionEventHandler OnIconSelection
        {
            add { this.Events.AddHandler(_onIconSelection, value); }
            remove { this.Events.RemoveHandler(_onIconSelection, value); }
        }
        protected internal virtual void RaiseOnIconSelection(OnIconSelectionEventArgs e)
        {
            OnIconSelectionEventHandler handler = (OnIconSelectionEventHandler)Events[_onIconSelection];
            if (handler != null) handler(GetEventSender(), e);
        }


        [Description("Gets or sets the source of images to be displayed within the editor."), Category(CategoryName.Appearance), TypeConverter(typeof(DevExpress.Utils.Design.ImageCollectionImagesConverter))]
        public virtual object ImageList
        {
            get { return imageList; }
            set
            {
                if (ImageList == value) return;
                imageList = value;
                OnPropertiesChanged();
            }
        }

        [Description("Gets or sets the index of the image displayed on the editor."), Category(CategoryName.Appearance), DefaultValue(-1), Editor(typeof(DevExpress.Utils.Design.ImageIndexesEditor), typeof(System.Drawing.Design.UITypeEditor)), ImageList("ImageList")]
        public virtual int ImageIndex
        {
            get { return imageIndex; }
            set
            {
                if (ImageIndex == value) return;
                imageIndex = value;
                OnPropertiesChanged();
            }
        }

        public override BaseEditViewInfo CreateViewInfo()
        {
            return new CustomIconTextEditViewInfo(this);
        }
        public override BaseEditPainter CreatePainter()
        {
            return new CustomIconTextEditPainter();
        }
    }

    public delegate void IconClickEventHandler(object sender, MouseEventArgs e);
    public delegate void OnIconSelectionEventHandler(object sender, OnIconSelectionEventArgs e);
    public class OnIconSelectionEventArgs : EventArgs
    {
        int imageIndex;
        object imageList;
        public OnIconSelectionEventArgs(object iconCollection, int iconIndex)
        {
            this.imageList = iconCollection;
            this.imageIndex = iconIndex;
        }
        public virtual int ImageIndex
        {
            get { return imageIndex; }
            set { imageIndex = value; }
        }
        public virtual object ImageList
        {
            get { return imageList; }
            //set { imageList = value; }
        }
    }
}

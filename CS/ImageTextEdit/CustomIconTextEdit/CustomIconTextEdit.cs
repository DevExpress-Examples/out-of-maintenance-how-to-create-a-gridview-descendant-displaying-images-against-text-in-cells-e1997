using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ImageTextEdit
{
    public class CustomIconTextEdit : TextEdit
    {
        static CustomIconTextEdit() { RepositoryItemCustomIconTextEdit.RegisterCustomIconTextEdit(); }

        public CustomIconTextEdit() : base() { }

        public override string EditorTypeName { get { return RepositoryItemCustomIconTextEdit.CustomIconTextEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomIconTextEdit Properties { get { return base.Properties as RepositoryItemCustomIconTextEdit; } }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            CustomIconTextEditViewInfo vi = ViewInfo as CustomIconTextEditViewInfo;
            if (vi.IsIconClick(e.Location))
            {
                int newX = e.X - vi.IconRect.Left;
                int newY = e.Y - vi.IconRect.Top;
                MouseEventArgs ee = new MouseEventArgs(e.Button, e.Clicks, newX, newY, e.Delta);
                Properties.RaiseIconClick(ee);
            }
            base.OnMouseDown(e);
        }
        public event IconClickEventHandler IconClick
        {
            add { this.Properties.IconClick += value; }
            remove { this.Properties.IconClick -= value; }
        }
    }

}

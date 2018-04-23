using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using System.Drawing;

namespace ImageTextEdit
{
    public class CustomIconTextEditPainter : TextEditPainter
    {
        public CustomIconTextEditPainter() : base() { }

        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            base.DrawContent(info);
            DrawIcon(info);
        }


        protected virtual void DrawIcon(ControlGraphicsInfoArgs info)
        {
            CustomIconTextEditViewInfo vi = info.ViewInfo as CustomIconTextEditViewInfo;
            OnIconSelectionEventArgs e = new OnIconSelectionEventArgs(vi.ImageList, vi.ImageIndex);
            vi.Item.RaiseOnIconSelection(e);
            if (e.ImageList != null && e.ImageIndex != -1)
                info.Cache.Paint.DrawImage(info.Cache, e.ImageList, e.ImageIndex, vi.IconRect, true);
            else
                info.Graphics.FillRectangle(info.Cache.GetSolidBrush(Color.White), vi.IconRect);

        }
    }

}

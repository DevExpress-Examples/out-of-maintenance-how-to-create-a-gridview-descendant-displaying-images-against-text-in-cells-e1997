using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using DevExpress.Utils;

namespace ImageTextEdit
{
    public class CustomIconTextEditViewInfo : TextEditViewInfo
    {
        Rectangle fIconRect;
        int SeparatorWidth = 3;

        public CustomIconTextEditViewInfo(RepositoryItem item)
            : base(item)
        {
            fIconRect = Rectangle.Empty;
        }


        protected virtual internal bool IsIconClick(Point p)
        {
            if (p.X > IconRect.Left && p.X < IconRect.Right && p.Y > IconRect.Top && p.Y < IconRect.Bottom) return true;
            else return false;
        }

        public object ImageList
        {
            get { return Item.ImageList; }
        }

        public int ImageIndex
        {
            get { return Item.ImageIndex; }
        }

        public virtual new RepositoryItemCustomIconTextEdit Item
        {
            get { return base.Item as RepositoryItemCustomIconTextEdit; }
        }

        protected override void Assign(BaseControlViewInfo info)
        {
            base.Assign(info);
            CustomIconTextEditViewInfo be = info as CustomIconTextEditViewInfo;
            if (be == null) return;
            this.fIconRect = be.fIconRect;
        }

        public override Size CalcBestFit(Graphics g)
        {
            Size s = base.CalcBestFit(g);
            s.Width = s.Width + SeparatorWidth * 2 + GetImageSize().Width;
            return s;
        }

        protected internal virtual Rectangle IconRect
        {
            get { return fIconRect; }
            set { fIconRect = value; }
        }

        public override void Offset(int x, int y)
        {
            base.Offset(x, y);
            if (!fIconRect.IsEmpty) this.fIconRect.Offset(x, y);
        }

        protected override Rectangle CalcMaskBoxRect(Rectangle content)
        {
            Rectangle r = base.CalcMaskBoxRect(content);
            r.Width = r.Width - GetImageSize().Width - SeparatorWidth;
            return r;
        }

        protected override void CalcContentRect(Rectangle bounds)
        {
            base.CalcContentRect(bounds);
            this.fIconRect = CalcIconRect(ContentRect);
        }

        protected virtual Rectangle CalcIconRect(Rectangle content)
        {
            Rectangle r = fMaskBoxRect;
            r.Size = GetImageSize();
            r.Location = new Point(fMaskBoxRect.Right + SeparatorWidth, content.Top + content.Height / 2 - r.Height / 2);
            return r;
        }

        protected Size GetImageSize()
        {
            ImageCollection ic = ImageList as ImageCollection;
            if (ic != null) return ic.ImageSize;
            return new Size(0, 0);
        }

        protected override int CalcMinHeightCore(Graphics g)
        {
            int imageHeight = 0;
            if (ImageList != null)
            {
                imageHeight = GetImageSize().Height;
                if (AllowDrawFocusRect)
                    imageHeight += (FocusRectThin + 1) * 2;
            }
            int fontHeight = base.CalcMinHeightCore(g);
            if (imageHeight > fontHeight) return imageHeight;
            else return fontHeight;
        }
    }

}

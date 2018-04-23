using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace ImageTextEdit
{
    public class CustomGridInfoRegistrator : GridInfoRegistrator
    {
        public CustomGridInfoRegistrator() : base() { }
        public override BaseViewPainter CreatePainter(BaseView view) { return new CustomGridPainter(view as CustomGridView); }
        public override string ViewName { get { return "CustomGridView"; } }
        public override BaseView CreateView(GridControl grid){return new CustomGridView(grid);}
    }
    public class CustomAdvGridInfoRegistrator : AdvBandedGridInfoRegistrator
    {
        public override string ViewName { get { return "CustomAdvGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new CustomAdvGridView(grid as GridControl); }
        public override BaseViewPainter CreatePainter(BaseView view) { return new CustomAdvGridPainter(view as CustomAdvGridView); }
    }


    //public class MyGridViewInfoRegistrator : GridInfoRegistrator
    //{
    //    public override string ViewName { get { return "MyGridView"; } }
    //    public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
    //    public override BaseViewPainter CreatePainter(BaseView view) { return new MyGridPainter(view as MyGridView); }
    //}
    //public class MyBandedGridViewInfoRegistrator : BandedGridInfoRegistrator
    //{
    //    public override string ViewName { get { return "MyBandedGridView"; } }
    //    public override BaseView CreateView(GridControl grid) { return new MyBandedGridView(grid as GridControl); }
    //    public override BaseViewPainter CreatePainter(BaseView view) { return new MyBandedGridPainter(view as MyBandedGridView); }
    //}


}

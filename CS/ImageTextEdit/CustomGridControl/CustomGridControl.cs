using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Container;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.ComponentModel;

namespace ImageTextEdit
{
    public class CustomGridControl : GridControl
    {
        public CustomGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridInfoRegistrator());
            collection.Add(new CustomAdvGridInfoRegistrator());
        }

        protected override BaseView CreateDefaultView()
        {
            return CreateView("CustomGridView");
        }
    }
    public delegate void OnSmartIconSelectionEventHandler(object sender, OnSmartIconSelectionEventArgs e);
    public class OnSmartIconSelectionEventArgs : OnIconSelectionEventArgs
    {
        bool isActiveEditor;
        GridCellInfo cellInfo;
        public OnSmartIconSelectionEventArgs(object iconCollection, int iconIndex, GridCellInfo cellInfo, bool isActiveEditor)
            : base(iconCollection, iconIndex)
        {
            this.cellInfo = cellInfo;
            this.isActiveEditor = isActiveEditor;
        }
        public GridCellInfo CellInfo { get { return cellInfo; } }
        public bool IsActiveEditor { get { return isActiveEditor; } }
    }

}

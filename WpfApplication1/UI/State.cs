using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;
using WpfApplication1.UI;

namespace WpfApplication1.UI
{
    public class State : ElementEntity
    {
        public enum StateType
        {
            Initial, Normal, Compound
        }

        #region Life Cycle Management
        public State()
            : base()
        {
            Initialize();
        }
        public State(Guid id)
            : base(id)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.DefaultHeight = 48;
            this.DefaultWidth = 48;
        }
        #endregion
        //protected override void OnMouseMove(MouseEventArgs e)
        //    {
        //        base.OnMouseMove(e);
        //        if (e.LeftButton == MouseButtonState.Pressed)
        //        {
        //            // Package the data.
        //            DataObject data = new DataObject();
        //            data.SetData(DataFormats.StringFormat, StateUI.Fill.ToString());
        //            data.SetData("Double",StateUI.Height);
        //            data.SetData("Object", this);

        //            // Inititate the drag-and-drop operation.
        //            DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
        //        }
        //    }
        //    protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        //    {
        //        base.OnGiveFeedback(e);
        //        // These Effects values are set in the drop target's
        //        // DragOver event handler.
        //        if (e.Effects.HasFlag(DragDropEffects.Copy))
        //        {
        //            Mouse.SetCursor(Cursors.Cross);
        //        }
        //        else if (e.Effects.HasFlag(DragDropEffects.Move))
        //        {
        //            Mouse.SetCursor(Cursors.Pen);
        //        }
        //        else
        //        {
        //            Mouse.SetCursor(Cursors.No);
        //        }
        //        e.Handled = true;
        //    }

    }

}

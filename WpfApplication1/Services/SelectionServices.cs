using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfApplication1.Services
{
    public class SelectionServices
    {
        #region Constructor
        public SelectionServices()
        {
        }
        #endregion
        internal void ElementEntity_DragDelta(object sender, RoutedEventArgs e)
        {
            Thumb myThumb = (Thumb)sender;
            DragDeltaEventArgs dea = e as DragDeltaEventArgs;
            double minleft = Canvas.GetLeft(myThumb);
            double minTop = Canvas.GetTop(myThumb);
            double DeltaVertical = Math.Max(-minTop, dea.VerticalChange);
            double DeltaHorizontal = Math.Max(-minleft, dea.HorizontalChange);
            double nTop = minTop + DeltaVertical;
            double nLeft = minleft + DeltaHorizontal;
            Canvas.SetTop(myThumb, nTop);
            Canvas.SetLeft(myThumb, nLeft);
        }

    }
}

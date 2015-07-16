using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1.UI
{
    /// <summary>
    /// ToolBoxItem.xaml 的交互逻辑
    /// </summary>
    public partial class ToolBoxItem : UserControl
    {
        public ToolBoxItem()
        {
            InitializeComponent();
        }
        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);
            //this.dragStartPoint = new Point?(e.GetPosition(this));

            DragObject dataObject = new DragObject();
            dataObject.ClassName = "State";
            DragDrop.DoDragDrop(this, dataObject, DragDropEffects.Copy);
        } 
    }
    public class DragObject
    {
        // Xaml string that represents the serialized content
        //public String Xaml { get; set; }

        // Defines width and height of the DesignItem
        // when this DragObject is dropped on the DesignCanvas
        //public Size? DesiredSize { get; set; }

        public string ClassName { get; set; }
    }
}

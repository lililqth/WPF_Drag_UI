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
using WpfApplication1.UI;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("事件");
            Console.WriteLine("事件被触发");

        }

        private void Grid_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Object"))
            {
                e.Effects = DragDropEffects.Copy;
                MessageBox.Show("drag over");
            }
        }

    //    private void Grid_Drop(object sender, DragEventArgs e)
    //    {
    //        if (e.Handled == false)
    //        {
    //            Panel _panel = (Panel)sender;
    //            UIElement _element = (UIElement)e.Data.GetData("Object");

    //            if (_panel != null && _element != null)
    //            {
    //                // Get the panel that the element currently belongs to,
    //                // then remove it from that panel and add it the Children of
    //                // the panel that its been dropped on.
    //                Panel _parent = (Panel)VisualTreeHelper.GetParent(_element);

    //                if (_parent != null)
    //                {
    //                    if (e.KeyStates == DragDropKeyStates.ControlKey &&
    //                        e.AllowedEffects.HasFlag(DragDropEffects.Copy))
    //                    {
    //                        State _state = new State((State)_element);
    //                        _panel.Children.Add(_state);
    //                        // set the value to return to the DoDragDrop call
    //                        e.Effects = DragDropEffects.Copy;
    //                    }
    //                    else if (e.AllowedEffects.HasFlag(DragDropEffects.Move))
    //                    {
    //                        _parent.Children.Remove(_element);
    //                        _panel.Children.Add(_element);
    //                        // set the value to return to the DoDragDrop call
    //                        e.Effects = DragDropEffects.Move;
    //                    }
    //                }
    //            }
    //        }
    //    }
    }
}

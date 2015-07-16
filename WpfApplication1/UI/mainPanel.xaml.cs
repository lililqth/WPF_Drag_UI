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
using System.Windows.Controls.Primitives;
using WpfApplication1.Services;

namespace WpfApplication1.UI
{
    /// <summary>
    /// mainPanel.xaml 的交互逻辑
    /// </summary>
    public partial class mainPanel : UserControl
    {
        #region properties
        private bool loaded = false;
        internal protected SelectionServices SelectionService { get; private set; }
        #endregion
        public mainPanel()
        {
            SelectionService = new SelectionServices();
          //  this.Loaded += new RoutedEventHandler(mainPanel_Loaded); 
            InitializeComponent();
        }
        //void mainPanel_Loaded(object sender, RoutedEventArgs e)
        //{
        //    if (!loaded)
        //    {
        //        AddHandler(ElementEntity.DragDeltaEvent, new RoutedEventHandler(SelectionService.ElementEntity_DragDelta));
        //    }
        //    loaded = true;
        //}

       

        protected override void OnDrop(DragEventArgs e)
        {
            base.OnDrop(e);
            DragObject dragObject = e.Data.GetData(typeof(DragObject)) as DragObject;
            if (dragObject != null)
            {
                Point position = e.GetPosition(this);
                Type t = Type.GetType(dragObject.ClassName);
                //ElementEntity newItem = t.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]) as ElementEntity;
                State newItem = new State();
                newItem.AddHandler(ElementEntity.DragDeltaEvent, new RoutedEventHandler(SelectionService.ElementEntity_DragDelta));
                Canvas.SetLeft(newItem, Math.Max(0, position.X - newItem.DefaultWidth / 2));
                Canvas.SetTop(newItem, Math.Max(0, position.Y - newItem.DefaultHeight / 2));
                newItem.Width = newItem.DefaultWidth;
                newItem.Height = newItem.DefaultHeight;
                //((State)newItem).Label = "S" + Children.OfType<State>().Count();
                g.Children.Add(newItem);
                e.Handled = true;
            }
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Source is Thumb)
            {
                MessageBox.Show("hello");
            }
        }

        private void Thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());
        }
        
    }
}

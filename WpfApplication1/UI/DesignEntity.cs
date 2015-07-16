using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;


namespace WpfApplication1.UI
{
    public class DesignEntity : Thumb ,IComparable<DesignEntity>
    {
        #region Constructor
        public DesignEntity()
            : this(Guid.NewGuid())
        {
        }

        public DesignEntity(Guid id)
            : base()
        {
            this.id = id;
            this.Selectable = true;
            this.Focusable = true;
        }
        #endregion

        #region Properties
        public bool Selectable { get; set; }

        protected Guid id;
        public Guid ID { get { return id; } }

        #endregion
        #region DependencyProperties
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(DesignEntity), new PropertyMetadata(false, new PropertyChangedCallback(IsSelectedPropertyCallback)));

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        private static void IsSelectedPropertyCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            DesignEntity entity = sender as DesignEntity;
            entity.OnIsSelectedChanged();
        }

        protected virtual void OnIsSelectedChanged() { }
        #endregion

        #region Event Handlers
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            e.Handled = false;

        }
        #endregion
        public virtual void Store(XElement root)
        {

        }

        public virtual void Destroy()
        {

        }

        public int CompareTo(DesignEntity other)
        {
            return this.id.CompareTo(other.id);
        }


    }
}

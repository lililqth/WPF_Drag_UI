using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace WpfApplication1.UI
{
    public class ElementEntity:DesignEntity
    {
        #region Constructor
        public ElementEntity()
            : base()
        {
            this.MouseEnter += new System.Windows.Input.MouseEventHandler(ElementEntity_MouseEnter);
            this.MouseLeave += new MouseEventHandler(ElementEntity_MouseLeave);
        }

        public ElementEntity(Guid id)
            : base(id)
        {
            this.MouseEnter += new System.Windows.Input.MouseEventHandler(ElementEntity_MouseEnter);
            this.MouseLeave += new MouseEventHandler(ElementEntity_MouseLeave);
        }

        void ElementEntity_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = null;
        }

        void ElementEntity_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }
        #endregion

        #region Properties
        public double DefaultHeight { get; set; }
        public double DefaultWidth { get; set; }
        #endregion

    }
}

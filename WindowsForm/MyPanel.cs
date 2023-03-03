using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public class MyPanel : FlowLayoutPanel
    {
        public MyPanel()
        {
            initialiseComp();
        }
        public void initialiseComp()
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlowDirection = FlowDirection.LeftToRight;
            this.Size = new System.Drawing.Size(750, 35);
        }
    }
}

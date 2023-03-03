using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsForm
{
    public class ComboxPanel : MyPanel
    {
        private Label l1;
        private ComboBox cmb;
        private string name;
        public ComboxPanel(string label, String[] items, int size)
        {
            name=label;
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            this.Controls.Add(l1);
            cmb = new ComboBox();
            cmb.Name = name;    
            cmb.Size = new System.Drawing.Size(size, 25);
            cmb.Items.AddRange(items);
            this.Controls.Add(cmb);
        }
        public ComboxPanel(string label, String[] items, int labelWidth, int labelHeight,int size)
        {
            name = label;
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            l1.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.Controls.Add(l1);
            cmb = new ComboBox();
            cmb.Name = name;
            cmb.Size = new System.Drawing.Size(size, 25);
            cmb.Items.AddRange(items);
            this.Controls.Add(cmb);
        }
    }
}

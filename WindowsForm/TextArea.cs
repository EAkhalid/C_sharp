using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public class TextArea : MyPanel
    {
        private Label l1;
        private TextBox t1;
        private string name;
        public TextArea(String label, int size)
        {
            name=label;
            this.Size = new System.Drawing.Size(600, 155);
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            t1 = new TextBox();
            t1.Size = new System.Drawing.Size(size, 150);
            t1.Multiline = true;
            t1.Name = name;
            this.Controls.Add(l1);
            this.Controls.Add(t1);
        }

        public TextArea(String label, int size, int labelWidth, int labelHeight)
        {
            name = label;
            this.Size = new System.Drawing.Size(600, 155);
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            l1.Size = new System.Drawing.Size(labelWidth, labelHeight);
            t1 = new TextBox();
            t1.Size = new System.Drawing.Size(size, 150);
            t1.Multiline = true;
            t1.Name = name;
            this.Controls.Add(l1);
            this.Controls.Add(t1);
        }
    }
}

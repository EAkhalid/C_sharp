using System.Reflection.Emit;
using System;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace WindowsForm
{
    public class LabeledTextField : MyPanel
    {
        private Label l1;
        private TextBox t1;
        private string name;
        public LabeledTextField(String label, int size)
        {
            name = label;
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text=label;
            t1 = new TextBox();
            t1.Size = new System.Drawing.Size(size,120);
            t1.Name = name;
            this.Controls.Add(l1);
            this.Controls.Add(t1);
        }
       
        public LabeledTextField(String label, int size, int labelWidth, int labelHeight)
        {
            name = label;
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            l1.Size = new System.Drawing.Size(labelWidth, labelHeight);
            t1 = new TextBox();
            t1.Name = name;
            t1.Size = new System.Drawing.Size(size, 25);
            this.Controls.Add(l1);
            this.Controls.Add(t1);
        }
    }
}
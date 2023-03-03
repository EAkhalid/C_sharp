using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    internal class ChoicePanel : MyPanel
    {
        private Label l1;
        private RadioButton rdButton;
        private string name;
        public ChoicePanel(string label,String[] items)
        {
            name = label;
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            this.Controls.Add(l1);
            foreach (string item in items)
            {
                rdButton = new RadioButton();
                rdButton.Text=item;
                rdButton.Name = name;
                this.Controls.Add(rdButton);    
            } 
        }
        public ChoicePanel(string label, String[] items, int labelWidth, int labelHeight)
        {
            name = label;
            if (!label.Contains(":")) label = label + " : ";
            l1 = new Label();
            l1.Text = label;
            l1.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.Controls.Add(l1);
            foreach (string item in items)
            {
                rdButton = new RadioButton();
                rdButton.Text = item;
                rdButton.Name = name;
                this.Controls.Add(rdButton);
            }
        }
    }
}
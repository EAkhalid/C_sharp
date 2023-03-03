using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public class ControlFactory : FormControlPanel
    {
        private string typeControle;
        private int labelWidth = 100;
        private int labelHeight = 25;
        private int size = 30;
        private string label;
        private string[] items;
        public ControlFactory(String typeControle, string label)
        {
            this.typeControle = typeControle;
            this.label = label;
        }
        public ControlFactory(int labelWidth, int labelHeight,int size, String typeControle, string label)
        {
            this.size = size;
            this.labelWidth = labelWidth;
            this.labelHeight = labelHeight;
            this.typeControle = typeControle;
            this.label = label;
        }
        public ControlFactory(int labelWidth, int labelHeight, int size, String typeControle, string label, string [] items)
        {
            this.size = size;
            this.labelWidth = labelWidth;
            this.labelHeight = labelHeight;
            this.typeControle = typeControle;
            this.label = label;
            this.items = items;
        }

        
        public override Control GetControl()
        {
            Control cr = null;
            if (typeControle == "TextBox")
            {
                if(labelWidth!=0 && labelHeight != 0)
                {
                    cr = new LabeledTextField(label, size, labelWidth, labelHeight);
                }
                else
                {
                    cr = new LabeledTextField(label, size);
                }
                
            }else if(typeControle == "RadioButton")
            {
                if (labelWidth != 0 && labelHeight != 0)
                {
                    cr = new ChoicePanel(label,items, labelWidth, labelHeight);
                }
                else
                {
                    cr = new ChoicePanel(label,items);
                }
            }
            else if (typeControle == "ComboBox")
            {
                if (labelWidth != 0 && labelHeight != 0)
                {
                    cr = new ComboxPanel(label, items, labelWidth, labelHeight,size);
                }
                else
                {
                    cr = new ComboxPanel(label, items,size);
                }
            }
            else if(typeControle == "TextArea")
            {
                if (labelWidth != 0 && labelHeight != 0)
                {
                    cr = new TextArea(label, size, labelWidth, labelHeight);
                }
                else
                {
                    cr = new TextArea(label, size);
                }
            }
            return cr;
            
        }
    }
}

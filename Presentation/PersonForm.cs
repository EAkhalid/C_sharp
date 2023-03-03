using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models;
using Annotation_Reflexion;
using WindowsForm;
using System.Windows.Forms;
using View = Annotation_Reflexion.View;

namespace Presentation
{
    public class PersonForm : Myform
    {
        private Button btnAdd;
        private Button btnRemove;
        private string[] proprieties;
        private DictionnaryManagement<Person> personManagement;
        public PersonForm(string title) : base(title)
        {
        }
        public PersonForm() :base("my form")
        {
            InitializeComponent();
            personManagement = new DictionnaryManagement<Person>();
        }
        public void InitializeComponent()
        {
            ControlFactory frmCtrlP;
            PropertyInfo[] myPropertyInfo;
            myPropertyInfo = typeof(Person).GetProperties();
            proprieties = new string[myPropertyInfo.Length];
            int i =0;
            foreach (PropertyInfo p in myPropertyInfo)
            {
                // for every property loop through all attributes
                foreach (Attribute a in p.GetCustomAttributes(false))
                {
                    View v = (View)a;
                    //save the name of controls
                    proprieties[i] = v.name;
                    i++;
                    //create control
                    if (v != null)
                    {
                        if (v.items == null) {
                            frmCtrlP = new ControlFactory(v.lblWidth, v.lblheigth, v.size, v.type, v.name);
                        }
                        else
                        {
                            frmCtrlP = new ControlFactory(v.lblWidth, v.lblheigth, v.size, v.type, v.name, v.items);
                        }
                        flowLayoutContent.Controls.Add(frmCtrlP.GetControl());
                    }
                }
            }
            //Init Button
            btnAdd = new Button();
            btnAdd.Text = "Add Person";
            btnAdd.Size = new System.Drawing.Size(120, 30);
            flowLayoutContent.Controls.Add(btnAdd);
            btnAdd.Click += BtnAdd_Click;
            btnRemove = new Button();
            btnRemove.Text = "Remove Person";
            btnRemove.Size = new System.Drawing.Size(120, 30);
            flowLayoutContent.Controls.Add(btnRemove);
            btnRemove.Click += BtnRemove_Click;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Control ctr = GetControlByName("Cin");
            if (ctr != null)
            {
                if (personManagement.RemovePerson(ctr.Text) == 1)
                {
                    MessageBox.Show("Person Removed", "Reflextion Test");
                }
                else
                {
                    MessageBox.Show("Person not exist", "Reflextion Test");
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
           if(addPerson() == 1)
            {
                MessageBox.Show("Person Added", "Reflextion Test");
            }
            else
            {
                MessageBox.Show("this person is already existed", "Reflextion Test");
            }
        }
        private int addPerson()
        {
            Person per = new Person();
            foreach(string prop in proprieties)
            {
                Control ctr = GetControlByName(prop);
                var propritiesInfo = typeof(Person).GetProperty(prop);
                if (ctr is TextBox || ctr is ComboBox)
                {
                    propritiesInfo.SetValue(per, ctr.Text);
                }else if(ctr is RadioButton) { 
                    if(((RadioButton)ctr).Checked) {
                        propritiesInfo.SetValue(per, ((char)ctr.Text[0]));
                    }
                }
                   
            }
            MessageBox.Show(personManagement.NbrPersonne().ToString());
            personManagement.Value = per;
            return personManagement.AddPerson(per.Cin);

        }

        private Control GetControlByName(string name)
        {
            Control ctrl = flowLayoutContent.Controls.Find(name, true).FirstOrDefault();
            return ctrl;
        }
    }
}

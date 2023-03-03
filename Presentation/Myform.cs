using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{

    public  class Myform : Form
    {
     
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         public Myform(string title)
        {
            this.Text=title;
            InitializeComponent();
        }
        public Myform()
        {
            InitializeComponent();
        }
        #region Code généré par le Concepteur Windows Form


        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.titleHeader = new System.Windows.Forms.Label();
            this.flowLayoutContent = new System.Windows.Forms.FlowLayoutPanel();
            this.footer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.flowLayoutMenu.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.sideBarPanel);
            this.leftPanel.Controls.Add(this.topPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 606);
            this.leftPanel.TabIndex = 4;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sideBarPanel.Controls.Add(this.flowLayoutMenu);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 107);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 499);
            this.sideBarPanel.TabIndex = 3;
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.AutoSize = true;
            this.flowLayoutMenu.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutMenu.Controls.Add(this.label2);
            this.flowLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutMenu.Size = new System.Drawing.Size(200, 499);
            this.flowLayoutMenu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SideBar";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(200, 107);
            this.topPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo Section";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.titleHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(915, 107);
            this.headerPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(411, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Header Section";
            // 
            // titleHeader
            // 
            this.titleHeader.AutoSize = true;
            this.titleHeader.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeader.ForeColor = System.Drawing.Color.GreenYellow;
            this.titleHeader.Location = new System.Drawing.Point(267, 24);
            this.titleHeader.Name = "titleHeader";
            this.titleHeader.Size = new System.Drawing.Size(0, 56);
            this.titleHeader.TabIndex = 0;
            this.titleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutContent
            // 
            this.flowLayoutContent.AutoScroll = true;
            this.flowLayoutContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.flowLayoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutContent.Location = new System.Drawing.Point(200, 107);
            this.flowLayoutContent.Name = "flowLayoutContent";
            this.flowLayoutContent.Padding = new System.Windows.Forms.Padding(40, 30, 10, 10);
            this.flowLayoutContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutContent.Size = new System.Drawing.Size(915, 499);
            this.flowLayoutContent.TabIndex = 6;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.footer.Controls.Add(this.label4);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(200, 565);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(915, 41);
            this.footer.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Footer Section";
            // 
            // Myform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 606);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.flowLayoutContent);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Myform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.leftPanel.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            this.flowLayoutMenu.ResumeLayout(false);
            this.flowLayoutMenu.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel topPanel;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        protected System.Windows.Forms.Panel headerPanel;
        protected System.Windows.Forms.Label titleHeader;
        protected Panel footer;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutContent;

       
    }
}

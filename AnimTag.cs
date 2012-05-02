using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimTag
{
    public partial class AnimTagForm : Form
    {
        AnimTagData data;

        Control CreateTagControl(Tag tag)
        {
            Label l = new Label();

            l.AutoSize = true;
            l.BackColor = System.Drawing.Color.Violet;
            l.Location = new System.Drawing.Point(80, 0);
            l.MinimumSize = new System.Drawing.Size(0, 28);
            l.Name = tag.name;
            l.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            //l.Size = new System.Drawing.Size(55, 28);
            l.TabIndex = 1;
            l.Text = tag.name;
            l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            l.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tagDoubleClick);

            return l;
        }
        public AnimTagForm()
        {
            InitializeComponent();

            data = new AnimTagData();

            AssignAnimationBox.DataSource = data.GetAllAnims();
            AssignAnimationBox.DisplayMember = "name";

            //foreach (Tag t in data.GetAllTags())
            //{
            //    AllTagsFlowLayoutPanel.Controls.Add(CreateTagControl(t));
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveTagsLayoutPanel.Controls.Clear();
            AllTagsFlowLayoutPanel.SuspendLayout();
            AllTagsFlowLayoutPanel.Controls.Clear();

            foreach (Tag t in data.GetAllTags())
            {
                AllTagsFlowLayoutPanel.Controls.Add(CreateTagControl(t));
            }
            AllTagsFlowLayoutPanel.ResumeLayout();

        }

        private void tagDoubleClick(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;

            if (l.Parent == AllTagsFlowLayoutPanel)
            {
                AllTagsFlowLayoutPanel.Controls.Remove(l);
                ActiveTagsLayoutPanel.Controls.Add(l);
            }
            else if (l.Parent == ActiveTagsLayoutPanel)
            {
                ActiveTagsLayoutPanel.Controls.Remove(l);
                AllTagsFlowLayoutPanel.Controls.Add(l);
            }

        }

    }
}

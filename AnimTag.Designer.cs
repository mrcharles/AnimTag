namespace AnimTag
{
    partial class AnimTagForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AssignPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.animSearchBox = new System.Windows.Forms.TextBox();
            this.AssignAnimationBox = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tagSearchBox = new System.Windows.Forms.TextBox();
            this.AllTagsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectPage = new System.Windows.Forms.TabPage();
            this.ActiveTagsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.AssignPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AssignPage);
            this.tabControl1.Controls.Add(this.SelectPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 706);
            this.tabControl1.TabIndex = 0;
            // 
            // AssignPage
            // 
            this.AssignPage.Controls.Add(this.splitContainer1);
            this.AssignPage.Location = new System.Drawing.Point(4, 22);
            this.AssignPage.Name = "AssignPage";
            this.AssignPage.Padding = new System.Windows.Forms.Padding(3);
            this.AssignPage.Size = new System.Drawing.Size(949, 680);
            this.AssignPage.TabIndex = 0;
            this.AssignPage.Text = "Assign";
            this.AssignPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.animSearchBox);
            this.splitContainer1.Panel1.Controls.Add(this.AssignAnimationBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(943, 674);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 0;
            // 
            // animSearchBox
            // 
            this.animSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.animSearchBox.Location = new System.Drawing.Point(0, 0);
            this.animSearchBox.Name = "animSearchBox";
            this.animSearchBox.Size = new System.Drawing.Size(191, 20);
            this.animSearchBox.TabIndex = 1;
            this.animSearchBox.Text = "Filter...";
            // 
            // AssignAnimationBox
            // 
            this.AssignAnimationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignAnimationBox.FormattingEnabled = true;
            this.AssignAnimationBox.Location = new System.Drawing.Point(5, 26);
            this.AssignAnimationBox.Name = "AssignAnimationBox";
            this.AssignAnimationBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AssignAnimationBox.Size = new System.Drawing.Size(183, 641);
            this.AssignAnimationBox.TabIndex = 0;
            this.AssignAnimationBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ActiveTagsLayoutPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tagSearchBox);
            this.splitContainer2.Panel2.Controls.Add(this.AllTagsFlowLayoutPanel);
            this.splitContainer2.Size = new System.Drawing.Size(748, 674);
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.TabIndex = 0;
            // 
            // tagSearchBox
            // 
            this.tagSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagSearchBox.Location = new System.Drawing.Point(0, 0);
            this.tagSearchBox.Name = "tagSearchBox";
            this.tagSearchBox.Size = new System.Drawing.Size(748, 20);
            this.tagSearchBox.TabIndex = 1;
            this.tagSearchBox.Text = "Filter...";
            // 
            // AllTagsFlowLayoutPanel
            // 
            this.AllTagsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTagsFlowLayoutPanel.Location = new System.Drawing.Point(3, 26);
            this.AllTagsFlowLayoutPanel.Name = "AllTagsFlowLayoutPanel";
            this.AllTagsFlowLayoutPanel.Size = new System.Drawing.Size(740, 476);
            this.AllTagsFlowLayoutPanel.TabIndex = 0;
            // 
            // SelectPage
            // 
            this.SelectPage.Location = new System.Drawing.Point(4, 22);
            this.SelectPage.Name = "SelectPage";
            this.SelectPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectPage.Size = new System.Drawing.Size(949, 680);
            this.SelectPage.TabIndex = 1;
            this.SelectPage.Text = "Select";
            this.SelectPage.UseVisualStyleBackColor = true;
            // 
            // ActiveTagsLayoutPanel
            // 
            this.ActiveTagsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveTagsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ActiveTagsLayoutPanel.Name = "ActiveTagsLayoutPanel";
            this.ActiveTagsLayoutPanel.Size = new System.Drawing.Size(748, 163);
            this.ActiveTagsLayoutPanel.TabIndex = 0;
            // 
            // AnimTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(957, 706);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnimTagForm";
            this.Text = "AnimTag";
            this.tabControl1.ResumeLayout(false);
            this.AssignPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AssignPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox AssignAnimationBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage SelectPage;
        private System.Windows.Forms.TextBox tagSearchBox;
        private System.Windows.Forms.FlowLayoutPanel AllTagsFlowLayoutPanel;
        private System.Windows.Forms.TextBox animSearchBox;
        private System.Windows.Forms.FlowLayoutPanel ActiveTagsLayoutPanel;
    }
}


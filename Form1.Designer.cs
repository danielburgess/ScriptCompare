namespace ScriptCompare
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftText = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.leftFileName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.leftChar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.noteBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.rightText = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rightFileName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.rightChar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.scriptAreaNumber = new System.Windows.Forms.ToolStripTextBox();
            this.ofTotalLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchOption = new System.Windows.Forms.ToolStripComboBox();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.textUpdate = new System.Windows.Forms.Timer(this.components);
            this.characterTimer = new System.Windows.Forms.Timer(this.components);
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.prevTimer = new System.Windows.Forms.Timer(this.components);
            this.openbothBut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.firstBut = new System.Windows.Forms.ToolStripButton();
            this.prevBut = new System.Windows.Forms.ToolStripButton();
            this.nextBut = new System.Windows.Forms.ToolStripButton();
            this.lastBut = new System.Windows.Forms.ToolStripButton();
            this.leftSaveBut = new System.Windows.Forms.ToolStripButton();
            this.leftSaveAsBut = new System.Windows.Forms.ToolStripButton();
            this.leftOpenBut = new System.Windows.Forms.ToolStripButton();
            this.rightSaveBut = new System.Windows.Forms.ToolStripButton();
            this.rightSaveAsBut = new System.Windows.Forms.ToolStripButton();
            this.rightOpenBut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.massRebuildButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftText);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip4);
            this.splitContainer1.Panel2.Controls.Add(this.rightText);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(1267, 295);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // leftText
            // 
            this.leftText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftText.Location = new System.Drawing.Point(0, 27);
            this.leftText.Margin = new System.Windows.Forms.Padding(4);
            this.leftText.Multiline = true;
            this.leftText.Name = "leftText";
            this.leftText.ReadOnly = true;
            this.leftText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.leftText.Size = new System.Drawing.Size(610, 268);
            this.leftText.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftSaveBut,
            this.leftSaveAsBut,
            this.leftOpenBut,
            this.toolStripSeparator4,
            this.leftFileName,
            this.toolStripSeparator6,
            this.leftChar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(610, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // leftFileName
            // 
            this.leftFileName.Name = "leftFileName";
            this.leftFileName.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // leftChar
            // 
            this.leftChar.Name = "leftChar";
            this.leftChar.Size = new System.Drawing.Size(90, 24);
            this.leftChar.Text = "0 Characters";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteBox,
            this.toolStripLabel1});
            this.toolStrip4.Location = new System.Drawing.Point(0, 268);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(652, 27);
            this.toolStrip4.TabIndex = 3;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // noteBox
            // 
            this.noteBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.noteBox.AutoSize = false;
            this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(466, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 24);
            this.toolStripLabel1.Text = "Line Notes";
            // 
            // rightText
            // 
            this.rightText.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightText.Location = new System.Drawing.Point(0, 27);
            this.rightText.Margin = new System.Windows.Forms.Padding(4);
            this.rightText.Multiline = true;
            this.rightText.Name = "rightText";
            this.rightText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rightText.Size = new System.Drawing.Size(652, 229);
            this.rightText.TabIndex = 2;
            this.rightText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightText_KeyDown);
            this.rightText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightText_KeyPress);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightSaveBut,
            this.rightSaveAsBut,
            this.rightOpenBut,
            this.toolStripButton2,
            this.massRebuildButton,
            this.toolStripSeparator5,
            this.rightFileName,
            this.toolStripSeparator7,
            this.rightChar,
            this.toolStripSeparator8});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(652, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // rightFileName
            // 
            this.rightFileName.Name = "rightFileName";
            this.rightFileName.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // rightChar
            // 
            this.rightChar.Name = "rightChar";
            this.rightChar.Size = new System.Drawing.Size(90, 24);
            this.rightChar.Text = "0 Characters";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openbothBut,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.scriptAreaNumber,
            this.ofTotalLabel,
            this.toolStripSeparator2,
            this.firstBut,
            this.prevBut,
            this.toolStripSeparator3,
            this.nextBut,
            this.lastBut,
            this.searchOption,
            this.searchBox});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip3.Size = new System.Drawing.Size(1267, 28);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // scriptAreaNumber
            // 
            this.scriptAreaNumber.Name = "scriptAreaNumber";
            this.scriptAreaNumber.Size = new System.Drawing.Size(132, 28);
            this.scriptAreaNumber.ToolTipText = "Script Area Number. Change to jump to script area";
            this.scriptAreaNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scriptAreaNumber_KeyPress);
            // 
            // ofTotalLabel
            // 
            this.ofTotalLabel.Name = "ofTotalLabel";
            this.ofTotalLabel.Size = new System.Drawing.Size(109, 25);
            this.ofTotalLabel.Text = "of 0 script lines";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // searchOption
            // 
            this.searchOption.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchOption.Items.AddRange(new object[] {
            "Search Left",
            "Search Right"});
            this.searchOption.Name = "searchOption";
            this.searchOption.Size = new System.Drawing.Size(160, 28);
            this.searchOption.ToolTipText = "Choose which side to search...";
            // 
            // searchBox
            // 
            this.searchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchBox.AutoSize = false;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(266, 27);
            this.searchBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchBox.ToolTipText = "Type here to search the script...";
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // textUpdate
            // 
            this.textUpdate.Enabled = true;
            this.textUpdate.Interval = 1000;
            this.textUpdate.Tick += new System.EventHandler(this.textUpdate_Tick);
            // 
            // characterTimer
            // 
            this.characterTimer.Enabled = true;
            this.characterTimer.Interval = 300;
            this.characterTimer.Tick += new System.EventHandler(this.characterTimer_Tick);
            // 
            // searchTimer
            // 
            this.searchTimer.Enabled = true;
            this.searchTimer.Interval = 1000;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // prevTimer
            // 
            this.prevTimer.Enabled = true;
            this.prevTimer.Interval = 1000;
            this.prevTimer.Tick += new System.EventHandler(this.prevTimer_Tick);
            // 
            // openbothBut
            // 
            this.openbothBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openbothBut.Image = global::ScriptCompare.Properties.Resources.ReopenFromServer;
            this.openbothBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openbothBut.Name = "openbothBut";
            this.openbothBut.Size = new System.Drawing.Size(24, 25);
            this.openbothBut.Text = "Open Both Left and Right files";
            this.openbothBut.Click += new System.EventHandler(this.openbothBut_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ScriptCompare.Properties.Resources.Configuration_16_3;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton1.Text = "Configuration Options";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // firstBut
            // 
            this.firstBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstBut.Image = global::ScriptCompare.Properties.Resources.MailMergeGoToFirstRecord;
            this.firstBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstBut.Name = "firstBut";
            this.firstBut.Size = new System.Drawing.Size(24, 25);
            this.firstBut.Text = "First Script Line";
            this.firstBut.Click += new System.EventHandler(this.firstBut_Click);
            // 
            // prevBut
            // 
            this.prevBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevBut.Image = global::ScriptCompare.Properties.Resources.PreviousPageOneNote;
            this.prevBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(24, 25);
            this.prevBut.Text = "Previous Script Line";
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // nextBut
            // 
            this.nextBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextBut.Image = global::ScriptCompare.Properties.Resources.ReadingViewNextPage;
            this.nextBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(24, 25);
            this.nextBut.Text = "Next Script Line";
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // lastBut
            // 
            this.lastBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastBut.Image = global::ScriptCompare.Properties.Resources.MailMergeGotToLastRecord;
            this.lastBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastBut.Name = "lastBut";
            this.lastBut.Size = new System.Drawing.Size(24, 25);
            this.lastBut.Text = "Last Script Line";
            this.lastBut.Click += new System.EventHandler(this.lastBut_Click);
            // 
            // leftSaveBut
            // 
            this.leftSaveBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftSaveBut.Image = global::ScriptCompare.Properties.Resources.SaveBusinessDataCatalogModel;
            this.leftSaveBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftSaveBut.Name = "leftSaveBut";
            this.leftSaveBut.Size = new System.Drawing.Size(24, 24);
            this.leftSaveBut.Text = "Save Left File";
            this.leftSaveBut.Visible = false;
            this.leftSaveBut.Click += new System.EventHandler(this.leftSaveBut_Click);
            // 
            // leftSaveAsBut
            // 
            this.leftSaveAsBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftSaveAsBut.Image = global::ScriptCompare.Properties.Resources.NotebookSaveAs;
            this.leftSaveAsBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftSaveAsBut.Name = "leftSaveAsBut";
            this.leftSaveAsBut.Size = new System.Drawing.Size(24, 24);
            this.leftSaveAsBut.Text = "Save Left File as...";
            this.leftSaveAsBut.Visible = false;
            this.leftSaveAsBut.Click += new System.EventHandler(this.leftSaveAsBut_Click);
            // 
            // leftOpenBut
            // 
            this.leftOpenBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftOpenBut.Image = global::ScriptCompare.Properties.Resources.ReopenFromServer;
            this.leftOpenBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftOpenBut.Name = "leftOpenBut";
            this.leftOpenBut.Size = new System.Drawing.Size(24, 24);
            this.leftOpenBut.Text = "Open Left File";
            this.leftOpenBut.Click += new System.EventHandler(this.leftOpenBut_Click);
            // 
            // rightSaveBut
            // 
            this.rightSaveBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightSaveBut.Image = global::ScriptCompare.Properties.Resources.SaveBusinessDataCatalogModel;
            this.rightSaveBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightSaveBut.Name = "rightSaveBut";
            this.rightSaveBut.Size = new System.Drawing.Size(24, 24);
            this.rightSaveBut.Text = "Save Right File";
            this.rightSaveBut.Click += new System.EventHandler(this.rightSaveBut_Click);
            // 
            // rightSaveAsBut
            // 
            this.rightSaveAsBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightSaveAsBut.Image = global::ScriptCompare.Properties.Resources.NotebookSaveAs;
            this.rightSaveAsBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightSaveAsBut.Name = "rightSaveAsBut";
            this.rightSaveAsBut.Size = new System.Drawing.Size(24, 24);
            this.rightSaveAsBut.Text = "Save Right File As...";
            this.rightSaveAsBut.Click += new System.EventHandler(this.rightSaveAsBut_Click);
            // 
            // rightOpenBut
            // 
            this.rightOpenBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightOpenBut.Image = global::ScriptCompare.Properties.Resources.ReopenFromServer;
            this.rightOpenBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightOpenBut.Name = "rightOpenBut";
            this.rightOpenBut.Size = new System.Drawing.Size(24, 24);
            this.rightOpenBut.Text = "Open Right File";
            this.rightOpenBut.Click += new System.EventHandler(this.rightOpenBut_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ScriptCompare.Properties.Resources.WordWrap_6774;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Line Re-Wrap";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // massRebuildButton
            // 
            this.massRebuildButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.massRebuildButton.Image = global::ScriptCompare.Properties.Resources.WordWrap_exp;
            this.massRebuildButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.massRebuildButton.Name = "massRebuildButton";
            this.massRebuildButton.Size = new System.Drawing.Size(24, 24);
            this.massRebuildButton.Text = "Mass line-break rebuild";
            this.massRebuildButton.Visible = false;
            this.massRebuildButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 326);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Script Compare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox leftText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton leftSaveBut;
        private System.Windows.Forms.TextBox rightText;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton rightSaveBut;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton openbothBut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox scriptAreaNumber;
        private System.Windows.Forms.ToolStripLabel ofTotalLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton firstBut;
        private System.Windows.Forms.ToolStripButton prevBut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton nextBut;
        private System.Windows.Forms.ToolStripButton lastBut;
        private System.Windows.Forms.ToolStripButton leftOpenBut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel leftFileName;
        private System.Windows.Forms.ToolStripButton leftSaveAsBut;
        private System.Windows.Forms.ToolStripButton rightOpenBut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel rightFileName;
        private System.Windows.Forms.ToolStripButton rightSaveAsBut;
        private System.Windows.Forms.Timer textUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel leftChar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel rightChar;
        private System.Windows.Forms.Timer characterTimer;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.ToolStripComboBox searchOption;
        private System.Windows.Forms.Timer prevTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripTextBox noteBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton massRebuildButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}


﻿namespace ScriptCompare
{
    partial class VWFPreview
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
            this.SuspendLayout();
            // 
            // VWFPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 218);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 840);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 234);
            this.Name = "VWFPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VWF Preview";
            this.Load += new System.EventHandler(this.Preview_Load);
            this.Shown += new System.EventHandler(this.Preview_Shown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
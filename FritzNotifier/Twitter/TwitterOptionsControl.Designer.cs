﻿namespace FritzNotifier.Twitter
{
    partial class TwitterOptionsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TweetCountCheckbox = new System.Windows.Forms.CheckBox();
            this.TweetCountMinutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TweetCountMinuteLabel = new System.Windows.Forms.Label();
            this.ReadDirectMessagecheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TweetCountMinutesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TweetCountCheckbox
            // 
            this.TweetCountCheckbox.AutoSize = true;
            this.TweetCountCheckbox.Location = new System.Drawing.Point(16, 30);
            this.TweetCountCheckbox.Name = "TweetCountCheckbox";
            this.TweetCountCheckbox.Size = new System.Drawing.Size(166, 17);
            this.TweetCountCheckbox.TabIndex = 0;
            this.TweetCountCheckbox.Text = "Read new tweet count every ";
            this.TweetCountCheckbox.UseVisualStyleBackColor = true;
            // 
            // TweetCountMinutesNumericUpDown
            // 
            this.TweetCountMinutesNumericUpDown.Location = new System.Drawing.Point(179, 30);
            this.TweetCountMinutesNumericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.TweetCountMinutesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TweetCountMinutesNumericUpDown.Name = "TweetCountMinutesNumericUpDown";
            this.TweetCountMinutesNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.TweetCountMinutesNumericUpDown.TabIndex = 1;
            this.TweetCountMinutesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TweetCountMinuteLabel
            // 
            this.TweetCountMinuteLabel.AutoSize = true;
            this.TweetCountMinuteLabel.Location = new System.Drawing.Point(225, 33);
            this.TweetCountMinuteLabel.Name = "TweetCountMinuteLabel";
            this.TweetCountMinuteLabel.Size = new System.Drawing.Size(46, 13);
            this.TweetCountMinuteLabel.TabIndex = 2;
            this.TweetCountMinuteLabel.Text = "minutes.";
            // 
            // ReadDirectMessagecheckBox
            // 
            this.ReadDirectMessagecheckBox.AutoSize = true;
            this.ReadDirectMessagecheckBox.Location = new System.Drawing.Point(16, 66);
            this.ReadDirectMessagecheckBox.Name = "ReadDirectMessagecheckBox";
            this.ReadDirectMessagecheckBox.Size = new System.Drawing.Size(154, 17);
            this.ReadDirectMessagecheckBox.TabIndex = 3;
            this.ReadDirectMessagecheckBox.Text = "Read new direct messages";
            this.ReadDirectMessagecheckBox.UseVisualStyleBackColor = true;
            // 
            // TwitterOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReadDirectMessagecheckBox);
            this.Controls.Add(this.TweetCountMinuteLabel);
            this.Controls.Add(this.TweetCountMinutesNumericUpDown);
            this.Controls.Add(this.TweetCountCheckbox);
            this.Name = "TwitterOptionsControl";
            this.Size = new System.Drawing.Size(394, 124);
            ((System.ComponentModel.ISupportInitialize)(this.TweetCountMinutesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TweetCountCheckbox;
        private System.Windows.Forms.NumericUpDown TweetCountMinutesNumericUpDown;
        private System.Windows.Forms.Label TweetCountMinuteLabel;
        private System.Windows.Forms.CheckBox ReadDirectMessagecheckBox;
    }
}

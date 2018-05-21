namespace MultiText.ui
{
    partial class SearchAndReplaceForm
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.searchNextButton = new System.Windows.Forms.Button();
            this.replaceCurStringButton = new System.Windows.Forms.Button();
            this.replaceAllStringButton = new System.Windows.Forms.Button();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(25, 25);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(98, 18);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "查找字符串";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(152, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(164, 28);
            this.searchTextBox.TabIndex = 1;
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(25, 70);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(98, 18);
            this.replaceLabel.TabIndex = 2;
            this.replaceLabel.Text = "替换字符串";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(152, 65);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(164, 28);
            this.replaceTextBox.TabIndex = 3;
            // 
            // searchNextButton
            // 
            this.searchNextButton.Location = new System.Drawing.Point(28, 114);
            this.searchNextButton.Name = "searchNextButton";
            this.searchNextButton.Size = new System.Drawing.Size(144, 35);
            this.searchNextButton.TabIndex = 4;
            this.searchNextButton.Text = "查找下一个";
            this.searchNextButton.UseVisualStyleBackColor = true;
            this.searchNextButton.Click += new System.EventHandler(this.searchNextButton_Click);
            // 
            // replaceCurStringButton
            // 
            this.replaceCurStringButton.Location = new System.Drawing.Point(28, 159);
            this.replaceCurStringButton.Name = "replaceCurStringButton";
            this.replaceCurStringButton.Size = new System.Drawing.Size(144, 35);
            this.replaceCurStringButton.TabIndex = 5;
            this.replaceCurStringButton.Text = "替换当前字符串";
            this.replaceCurStringButton.UseVisualStyleBackColor = true;
            this.replaceCurStringButton.Click += new System.EventHandler(this.replaceCurStringButton_Click);
            // 
            // replaceAllStringButton
            // 
            this.replaceAllStringButton.Location = new System.Drawing.Point(190, 159);
            this.replaceAllStringButton.Name = "replaceAllStringButton";
            this.replaceAllStringButton.Size = new System.Drawing.Size(144, 35);
            this.replaceAllStringButton.TabIndex = 7;
            this.replaceAllStringButton.Text = "替换所有字符串";
            this.replaceAllStringButton.UseVisualStyleBackColor = true;
            this.replaceAllStringButton.Click += new System.EventHandler(this.replaceAllStringButton_Click);
            // 
            // searchAllButton
            // 
            this.searchAllButton.Location = new System.Drawing.Point(190, 114);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(144, 35);
            this.searchAllButton.TabIndex = 6;
            this.searchAllButton.Text = "查找所有";
            this.searchAllButton.UseVisualStyleBackColor = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // SearchAndReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 200);
            this.Controls.Add(this.replaceAllStringButton);
            this.Controls.Add(this.searchAllButton);
            this.Controls.Add(this.replaceCurStringButton);
            this.Controls.Add(this.searchNextButton);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchAndReplaceForm";
            this.Text = "查找和替换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Button searchNextButton;
        private System.Windows.Forms.Button replaceCurStringButton;
        private System.Windows.Forms.Button replaceAllStringButton;
        private System.Windows.Forms.Button searchAllButton;
    }
}
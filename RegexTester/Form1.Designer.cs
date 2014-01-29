namespace RegexTester
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.matchRadioButton = new System.Windows.Forms.RadioButton();
            this.replaceRadioButton = new System.Windows.Forms.RadioButton();
            this.ignoreCheckBox = new System.Windows.Forms.CheckBox();
            this.evaluateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(38, 21);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(34, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input:";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(38, 64);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(44, 13);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "Pattern:";
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(38, 127);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(50, 13);
            this.replaceLabel.TabIndex = 2;
            this.replaceLabel.Text = "Replace:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(38, 179);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(92, 14);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(332, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(92, 57);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(332, 20);
            this.patternTextBox.TabIndex = 5;
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(92, 124);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(332, 20);
            this.replaceTextBox.TabIndex = 6;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.IntegralHeight = false;
            this.resultListBox.Location = new System.Drawing.Point(92, 179);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.ScrollAlwaysVisible = true;
            this.resultListBox.Size = new System.Drawing.Size(332, 225);
            this.resultListBox.TabIndex = 7;
            // 
            // matchRadioButton
            // 
            this.matchRadioButton.AutoSize = true;
            this.matchRadioButton.Location = new System.Drawing.Point(476, 132);
            this.matchRadioButton.Name = "matchRadioButton";
            this.matchRadioButton.Size = new System.Drawing.Size(55, 17);
            this.matchRadioButton.TabIndex = 8;
            this.matchRadioButton.TabStop = true;
            this.matchRadioButton.Text = "Match";
            this.matchRadioButton.UseVisualStyleBackColor = true;
            this.matchRadioButton.CheckedChanged += new System.EventHandler(this.matchRadioButton_CheckedChanged);
            // 
            // replaceRadioButton
            // 
            this.replaceRadioButton.AutoSize = true;
            this.replaceRadioButton.Location = new System.Drawing.Point(588, 132);
            this.replaceRadioButton.Name = "replaceRadioButton";
            this.replaceRadioButton.Size = new System.Drawing.Size(65, 17);
            this.replaceRadioButton.TabIndex = 9;
            this.replaceRadioButton.TabStop = true;
            this.replaceRadioButton.Text = "Replace";
            this.replaceRadioButton.UseVisualStyleBackColor = true;
            this.replaceRadioButton.CheckedChanged += new System.EventHandler(this.replaceRadioButton_CheckedChanged);
            // 
            // ignoreCheckBox
            // 
            this.ignoreCheckBox.AutoSize = true;
            this.ignoreCheckBox.Location = new System.Drawing.Point(476, 175);
            this.ignoreCheckBox.Name = "ignoreCheckBox";
            this.ignoreCheckBox.Size = new System.Drawing.Size(83, 17);
            this.ignoreCheckBox.TabIndex = 10;
            this.ignoreCheckBox.Text = "Ignore Case";
            this.ignoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(476, 233);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 11;
            this.evaluateButton.Text = "Evaluate";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(598, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(99, 163);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 419);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.evaluateButton);
            this.Controls.Add(this.ignoreCheckBox);
            this.Controls.Add(this.replaceRadioButton);
            this.Controls.Add(this.matchRadioButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.replaceLabel);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.RadioButton matchRadioButton;
        private System.Windows.Forms.RadioButton replaceRadioButton;
        private System.Windows.Forms.CheckBox ignoreCheckBox;
        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label errorLabel;
    }
}


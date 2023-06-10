namespace RPMSanyShiriCH
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.xLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // xLabel
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(12, 15);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "x:";

            // xTextBox
            this.xTextBox.Location = new System.Drawing.Point(35, 12);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 1;

            // epsilonLabel
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Location = new System.Drawing.Point(157, 15);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(46, 13);
            this.epsilonLabel.TabIndex = 2;
            this.epsilonLabel.Text = "Epsilon:";

            // epsilonTextBox
            this.epsilonTextBox.Location = new System.Drawing.Point(209, 12);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(100, 20);
            this.epsilonTextBox.TabIndex = 3;

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(15, 45);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // resultListBox
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(15, 85);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(294, 147);
            this.resultListBox.TabIndex = 5;

            // saveButton
            this.saveButton.Location = new System.Drawing.Point(234, 45);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 247);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.epsilonLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.xLabel);
            this.Name = "MainForm";
            this.Text = "RPMSanyShiri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label epsilonLabel;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button saveButton;
    }
}



namespace PostManCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ApiLinkLabel = new Label();
            ApiLinktextBox = new TextBox();
            FetchButton = new Button();
            ResponseLabel = new Label();
            ResponseTextBox = new TextBox();
            SuspendLayout();
            // 
            // ApiLinkLabel
            // 
            ApiLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApiLinkLabel.Location = new Point(12, 9);
            ApiLinkLabel.Name = "ApiLinkLabel";
            ApiLinkLabel.Size = new Size(58, 32);
            ApiLinkLabel.TabIndex = 0;
            ApiLinkLabel.Text = "Api ";
            ApiLinkLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ApiLinktextBox
            // 
            ApiLinktextBox.Location = new Point(12, 44);
            ApiLinktextBox.Name = "ApiLinktextBox";
            ApiLinktextBox.ScrollBars = ScrollBars.Horizontal;
            ApiLinktextBox.Size = new Size(662, 27);
            ApiLinktextBox.TabIndex = 1;
            // 
            // FetchButton
            // 
            FetchButton.Location = new Point(694, 42);
            FetchButton.Name = "FetchButton";
            FetchButton.Size = new Size(94, 29);
            FetchButton.TabIndex = 2;
            FetchButton.Text = "Fetch";
            FetchButton.UseVisualStyleBackColor = true;
            FetchButton.Click += FetchButton_Click;
            // 
            // ResponseLabel
            // 
            ResponseLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResponseLabel.Location = new Point(12, 93);
            ResponseLabel.Name = "ResponseLabel";
            ResponseLabel.Size = new Size(114, 30);
            ResponseLabel.TabIndex = 3;
            ResponseLabel.Text = "Response :";
            ResponseLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BackColor = Color.White;
            ResponseTextBox.Location = new Point(12, 126);
            ResponseTextBox.Multiline = true;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            ResponseTextBox.ScrollBars = ScrollBars.Both;
            ResponseTextBox.Size = new Size(662, 312);
            ResponseTextBox.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResponseTextBox);
            Controls.Add(ResponseLabel);
            Controls.Add(FetchButton);
            Controls.Add(ApiLinktextBox);
            Controls.Add(ApiLinkLabel);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ApiLinkLabel;
        private TextBox ApiLinktextBox;
        private Button FetchButton;
        private Label ResponseLabel;
        private TextBox ResponseTextBox;
    }
}

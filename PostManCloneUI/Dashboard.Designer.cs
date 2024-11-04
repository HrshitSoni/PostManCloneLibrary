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
            ResponseLabel = new Label();
            ResponseTextBox = new TextBox();
            ResetButton = new Button();
            MethodsComboBox = new ComboBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // ApiLinkLabel
            // 
            ApiLinkLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApiLinkLabel.Location = new Point(5, 10);
            ApiLinkLabel.Name = "ApiLinkLabel";
            ApiLinkLabel.Size = new Size(58, 32);
            ApiLinkLabel.TabIndex = 0;
            ApiLinkLabel.Text = "Api :";
            ApiLinkLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ApiLinktextBox
            // 
            ApiLinktextBox.BackColor = Color.LightGray;
            ApiLinktextBox.Location = new Point(12, 44);
            ApiLinktextBox.Name = "ApiLinktextBox";
            ApiLinktextBox.ScrollBars = ScrollBars.Horizontal;
            ApiLinktextBox.Size = new Size(662, 27);
            ApiLinktextBox.TabIndex = 1;
            // 
            // ResponseLabel
            // 
            ResponseLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResponseLabel.Location = new Point(1, 93);
            ResponseLabel.Name = "ResponseLabel";
            ResponseLabel.Size = new Size(114, 30);
            ResponseLabel.TabIndex = 3;
            ResponseLabel.Text = "Response :";
            ResponseLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BackColor = Color.LightGray;
            ResponseTextBox.Location = new Point(12, 126);
            ResponseTextBox.Multiline = true;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            ResponseTextBox.ScrollBars = ScrollBars.Both;
            ResponseTextBox.Size = new Size(662, 312);
            ResponseTextBox.TabIndex = 4;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(694, 114);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // MethodsComboBox
            // 
            MethodsComboBox.AccessibleName = "";
            MethodsComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            MethodsComboBox.FormattingEnabled = true;
            MethodsComboBox.Items.AddRange(new object[] { "GET", "POST", "PUT", "DELETE", "PATCH" });
            MethodsComboBox.Location = new Point(694, 14);
            MethodsComboBox.Name = "MethodsComboBox";
            MethodsComboBox.Size = new Size(94, 28);
            MethodsComboBox.TabIndex = 6;
            MethodsComboBox.Text = "GET";
            MethodsComboBox.SelectedIndexChanged += MethodsComboBox_SelectedIndexChanged;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(694, 61);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 7;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(SendButton);
            Controls.Add(MethodsComboBox);
            Controls.Add(ResetButton);
            Controls.Add(ResponseTextBox);
            Controls.Add(ResponseLabel);
            Controls.Add(ApiLinktextBox);
            Controls.Add(ApiLinkLabel);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Post_Man_Clone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ApiLinkLabel;
        private TextBox ApiLinktextBox;
        private Label ResponseLabel;
        private TextBox ResponseTextBox;
        private Button ResetButton;
        private ComboBox MethodsComboBox;
        private Button SendButton;
    }
}

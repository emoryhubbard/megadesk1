namespace megadesk1 {
    partial class ViewQuoteForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rushBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.viewQuoteBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rushBox
            // 
            this.rushBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rushBox.FormattingEnabled = true;
            this.rushBox.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "Non-Rush (14 Days)"});
            this.rushBox.Location = new System.Drawing.Point(122, 632);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(0, 36);
            this.rushBox.TabIndex = 28;
            this.rushBox.Text = "Rush Order Options";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(36, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 48);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // viewQuoteBox
            // 
            this.viewQuoteBox.Location = new System.Drawing.Point(102, 132);
            this.viewQuoteBox.Name = "viewQuoteBox";
            this.viewQuoteBox.Size = new System.Drawing.Size(289, 574);
            this.viewQuoteBox.TabIndex = 30;
            this.viewQuoteBox.Text = "";
            // 
            // ViewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 818);
            this.Controls.Add(this.viewQuoteBox);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.backButton);
            this.Name = "ViewQuote";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox rushBox;
        private Button backButton;
        private RichTextBox viewQuoteBox;
    }
}
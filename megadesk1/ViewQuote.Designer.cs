namespace megadesk1 {
    partial class ViewQuote {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.viewQuoteBox = new System.Windows.Forms.RichTextBox();
            this.rushBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewQuoteBox
            // 
            this.viewQuoteBox.Location = new System.Drawing.Point(107, 138);
            this.viewQuoteBox.Name = "viewQuoteBox";
            this.viewQuoteBox.Size = new System.Drawing.Size(289, 574);
            this.viewQuoteBox.TabIndex = 33;
            this.viewQuoteBox.Text = "";
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
            this.rushBox.Location = new System.Drawing.Point(127, 638);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(0, 36);
            this.rushBox.TabIndex = 32;
            this.rushBox.Text = "Rush Order Options";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(41, 39);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 48);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ViewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewQuoteBox);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.backButton);
            this.Name = "ViewQuote";
            this.Size = new System.Drawing.Size(495, 818);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox viewQuoteBox;
        private ComboBox rushBox;
        private Button backButton;
    }
}

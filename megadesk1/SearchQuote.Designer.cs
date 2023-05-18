namespace megadesk1 {
    partial class SearchQuote {
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
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // viewQuoteBox
            // 
            this.viewQuoteBox.Location = new System.Drawing.Point(101, 237);
            this.viewQuoteBox.Name = "viewQuoteBox";
            this.viewQuoteBox.Size = new System.Drawing.Size(289, 485);
            this.viewQuoteBox.TabIndex = 36;
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
            this.rushBox.Location = new System.Drawing.Point(121, 676);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(0, 36);
            this.rushBox.TabIndex = 35;
            this.rushBox.Text = "Rush Order Options";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(50, 46);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 48);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // materialBox
            // 
            this.materialBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialBox.Location = new System.Drawing.Point(101, 166);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(218, 36);
            this.materialBox.TabIndex = 37;
            this.materialBox.Text = "Material";
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.viewQuoteBox);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.backButton);
            this.Name = "SearchQuote";
            this.Size = new System.Drawing.Size(495, 818);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox viewQuoteBox;
        private ComboBox rushBox;
        private Button backButton;
        private ComboBox materialBox;
    }
}

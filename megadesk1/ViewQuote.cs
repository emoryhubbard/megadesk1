using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megadesk1 {
    public partial class ViewQuote : UserControl {
        public MainForm MainForm { get { return (MainForm)Tag; } }

        public ViewQuote() {
            InitializeComponent();
            backButton.Click += new EventHandler(backButton_Click);
            viewQuoteBox.Text = File.ReadAllText("DeskQuotes.txt");
        }

        private void backButton_Click(object sender, EventArgs e) {
            MainForm.SetBody(new MainMenu());
        }
    }
}

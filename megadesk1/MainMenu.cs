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
    public partial class MainMenu : UserControl {
        public MainForm MainForm { get { return (MainForm)Tag; } }
        public MainMenu() {
            InitializeComponent();
            addQuoteButton.Click += new EventHandler(addQuoteButton_Click);
            viewQuoteButton.Click += new EventHandler(viewQuoteButton_Click);
            searchQuoteButton.Click += new EventHandler(searchQuoteButton_Click);
            exitButton.Click += new EventHandler(exitButton_Click);
        }
        public void addQuoteButton_Click(Object sender, EventArgs e) {
            MainForm.SetBody(new AddQuote());
        }
        public void viewQuoteButton_Click(Object sender, EventArgs e) {
            MainForm.SetBody(new ViewQuote());
        }
        private void searchQuoteButton_Click(Object sender, EventArgs e) {
            MainForm.SetBody(new SearchQuote());
        }
        public void exitButton_Click(Object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

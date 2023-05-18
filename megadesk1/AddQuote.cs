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
    public partial class AddQuote : UserControl {
        public MainForm MainForm { get { return (MainForm)Tag; } }

        public AddQuote() {
            InitializeComponent();
            backButton.Click += new EventHandler(backButton_Click);
            getQuote.Click += new EventHandler(getQuoteButton_Click);
            //File.WriteAllText("DeskQuotes.txt", "");
        }
        private void backButton_Click(object sender, EventArgs e) {
            MainForm.SetBody(new MainMenu());
        }
        private void getQuoteButton_Click(object sender, EventArgs eventArgs) {
            try {
                Desk desk = new Desk(widthBox.Text, depthBox.Text, drawersBox.Text, materialBox.Text);
                DeskQuote quote = new DeskQuote(desk, firstNameBox.Text, lastNameBox.Text, rushBox.Text);
                MainForm.SetBody(new DisplayQuote(quote));
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }
    }
}

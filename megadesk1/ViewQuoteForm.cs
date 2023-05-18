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
    public partial class ViewQuoteForm : Form {
        public ViewQuoteForm() {
            InitializeComponent();
            this.Icon = Properties.Resources.UnitOfMeasure;
            viewQuoteBox.Text = File.ReadAllText("DeskQuotes.txt");
        }

        private void backButton_Click(object sender, EventArgs e) {
            Form previousForm = (Form)Tag;
            previousForm.Show();
            Close();
        }
    }
}

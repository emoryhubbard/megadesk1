﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megadesk1 {
    public partial class AddQuoteForm : Form {
        public AddQuoteForm() {
            InitializeComponent();
            this.Icon = Properties.Resources.UnitOfMeasure;
        }

        private void backButton_Click(object sender, EventArgs e) {
            Form previousForm = (Form) Tag;
            previousForm.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void saveButton_Click(object sender, EventArgs e) {
            string quote = "\n" +
                "\n" + firstNameBox.Text +
                "\n" + lastNameBox.Text +
                "\n" + depthBox.Text +
                "\n" + heightBox.Text +
                "\n" + materialBox.Text +
                "\n" + rushBox.Text;

            File.AppendAllText("DeskQuotes.txt", quote);
            MessageBox.Show("Quote successfully saved to disk!");
        }
    }
}

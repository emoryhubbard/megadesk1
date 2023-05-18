using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megadesk1 {
    public partial class DisplayQuote : UserControl {
        DeskQuote quote;
        public MainForm MainForm { get { return (MainForm)Tag; } }

        public DisplayQuote(DeskQuote quote) {
            InitializeComponent();
            this.quote = quote;

            backButton.Click += new EventHandler(backButton_Click);
            mainMenuButton.Click += new EventHandler(mainMenu_Click);
            RenderQuote();
            SaveQuote();
        }
        public void RenderQuote() {
            firstNameBox.Text = quote.FirstName;
            lastNameBox.Text = quote.LastName;
            widthBox.Text = quote.Desk.Width.ToString() + " in.";
            depthBox.Text = quote.Desk.Depth.ToString() + " in.";
            drawersBox.Text = quote.Desk.Drawers.ToString();
            materialBox.Text = quote.Desk.Material;
            rushBox.Text = quote.RushDays.ToString();
            dateBox.Text = quote.Date.ToString("M/d/yyyy");
            totalBox.Text = String.Format("{0, 0:C2}", GetTotal());
        }
        public int GetTotal() {
            int total = 0;
            int basePrice = 200;
            int drawerPrice = 50;
            int desktopArea = quote.Desk.Width * quote.Desk.Depth;

            total += basePrice;
            if (desktopArea > 1000)
                total += desktopArea;
            total += GetMaterialPrice();
            total += quote.Desk.Drawers * drawerPrice;
            total += GetRushPrice();

            return total;
        }
        public int GetMaterialPrice() {
            int total = 0;
            int drawerPrice = 50;
            int oakPrice = 200;
            int laminatePrice = 100;
            int pinePrice = 50;
            int rosewoodPrice = 300;
            int veneerPrice = 125;

            total += quote.Desk.Drawers * drawerPrice;
            if (quote.Desk.Material == "Oak")
                total += oakPrice;
            if (quote.Desk.Material == "Laminate")
                total += laminatePrice;
            if (quote.Desk.Material == "Pine")
                total += pinePrice;
            if (quote.Desk.Material == "Rosewood")
                total += rosewoodPrice;
            if (quote.Desk.Material == "Veneer")
                total += veneerPrice;
            return total;
        }
        public int GetRushPrice() {
            int total = 0;
            int desktopArea = quote.Desk.Width * quote.Desk.Depth;
            if (quote.RushDays == 3) {
                if (desktopArea < 1000)
                    total += 60;
                if (desktopArea >= 1000 && desktopArea <= 200)
                    total += 70;
                if (desktopArea > 2000)
                    total += 80;
            }
            if (quote.RushDays == 5) {
                if (desktopArea < 1000)
                    total += 40;
                if (desktopArea >= 1000 && desktopArea <= 200)
                    total += 50;
                if (desktopArea > 2000)
                    total += 60;
            }
            if (quote.RushDays == 5) {
                if (desktopArea < 1000)
                    total += 30;
                if (desktopArea >= 1000 && desktopArea <= 200)
                    total += 35;
                if (desktopArea > 2000)
                    total += 40;
            }
            return total;
        }
        public void SaveQuote() {
            string entry = "\n" +
                            "\n" + quote.FirstName +
                            "\n" + quote.LastName +
                            "\n" + quote.Desk.Width.ToString() + " in." +
                            "\n" + quote.Desk.Depth.ToString() + " in." +
                            "\n" + quote.Desk.Material.ToString() +
                            "\n" + quote.RushDays.ToString() +
                            "\n" + quote.Date.ToString("M/d/yyyy") +
                            "\n" + String.Format("{0, 0:C2}", GetTotal());

            File.AppendAllText("DeskQuotes.txt", entry);
        }

        private void backButton_Click(object sender, EventArgs e) {
            MainForm.SetBody(new AddQuote());
        }

        private void getQuote_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }
        private void mainMenu_Click(object sender, EventArgs e) {
            MainForm.SetBody(new MainMenu());
        }
    }
}

using System.Windows.Forms;

namespace megadesk1 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.Icon = Properties.Resources.UnitOfMeasure;
            this.Layout += new LayoutEventHandler(MainForm_Layout);
            SetBody(new MainMenu());
        }
        public void SetBody(Control body) {
            body.Tag = this;
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(body);
            CenterBody(); // Layout change isn't always triggered
        }
        public void CenterBody() {
            ExpandBody();
            bodyPanel.Anchor = AnchorStyles.Top;
            bodyPanel.Anchor = AnchorStyles.Left;

            if (bodyPanel.Controls.Count == 0)
                return;
            Control body = bodyPanel.Controls[0];
            body.Top = bodyPanel.Height / 2 - body.Height / 2;
            body.Left = bodyPanel.Width / 2 - body.Width / 2;
        }
        public void MainForm_Layout(object sender, EventArgs e) {
            CenterBody();
            //MessageBox.Show("Layout changed");
        }
        public void ExpandBody() {
            bodyPanel.Height = ClientSize.Height;
            bodyPanel.Width = ClientSize.Width;
        }
    }
}
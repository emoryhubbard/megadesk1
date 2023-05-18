using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megadesk1 {
    internal class Utils {
        public static void setBody(UserControl body, Panel bodyPanel) {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(body);
        }
        public static void centerBody(UserControl body, Panel bodyPanel) {
            bodyPanel.Anchor = AnchorStyles.Top;
            bodyPanel.Anchor = AnchorStyles.Left;
            body.Top = bodyPanel.Height / 2 - body.Height / 2;
            body.Left = bodyPanel.Width / 2 - body.Width / 2;
        }
    }
}

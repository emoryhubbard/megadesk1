using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megadesk1 {
    public class Desk {
        public int Width { get; }
        public int Depth { get; }
        public int Drawers { get; }
        public string Material { get; }
        public Desk(string width, string depth, string drawers, string material) {
            int widthInt;
            if (!int.TryParse(width, out widthInt))
                throw new Exception("Invalid width: Please enter an integer.");
            int depthInt;
            if (!int.TryParse(depth, out depthInt))
                throw new Exception("Invalid depth: Please enter an integer.");
            int drawersInt;
            if (!int.TryParse(drawers, out drawersInt))
                throw new Exception("Invalid drawers: Please enter an integer.");
            this.Width = widthInt;
            this.Depth = depthInt;
            this.Drawers = drawersInt;
            this.Material = material;

            if (this.Width < 24 || this.Width > 96)
                throw new Exception("Invalid width: Please enter a width within 24 - 96.");
            if (this.Depth < 12 || this.Depth > 48)
                throw new Exception("Invalid depth: Please enter a depth within 12 - 48.");
            if (this.Drawers < 0 || this.Drawers > 7)
                throw new Exception("Invalid drawers: Please enter a number of drawers within 0 - 7.");
            if (this.Material != "Laminate"
                && this.Material != "Oak"
                && this.Material != "Rosewood"
                && this.Material != "Veneer"
                && this.Material != "Pine")
                throw new Exception("Invalid material: Please choose one of the available materials.");
        }
        public Desk(int width, int depth, int drawers, string material) {
            this.Width = width;
            this.Depth = depth;
            this.Drawers = drawers;
            this.Material = material;
        }
    }
}

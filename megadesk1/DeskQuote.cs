using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megadesk1 {
    public class DeskQuote {
        public Desk Desk { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int RushDays { get; }
        public DateTime Date { get; }
        public DeskQuote(Desk desk, string firstName, string lastName, string rushDays) {
            this.Desk = desk;
            this.FirstName = firstName;
            this.LastName = lastName;
            string rushDigits = new String(rushDays.Where(Char.IsDigit).ToArray());
            int rushInt;
            if (!int.TryParse(rushDigits, out rushInt))
                throw new Exception("Invalid rush order options: Please select an option.");
            this.RushDays = rushInt;
            this.Date = DateTime.Now;

            if (this.FirstName == "" || this.FirstName == null)
                throw new Exception("Invalid first name: Please enter a first name.");
            if (this.LastName == "" || this.LastName == null)
                throw new Exception("Invalid last name: Please enter a last name.");
            if (this.RushDays != 3 && this.RushDays != 5
                && this.RushDays != 7 && this.RushDays != 14)
                throw new Exception("Invalid rush order options: Please choose 3, 5, 7, or 14.");
        }
        public DeskQuote(Desk desk, string firstName, string lastName, int rushDays) {
            this.Desk = desk;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.RushDays = rushDays;
        }
    }
}

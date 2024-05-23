namespace DG.DashboardShopZuerich.Models
{
    public class Employees
    {
        // Attribute
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtstag { get; set; }

        // Konstruktor
        public Employees(string name, string vorname, DateTime geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag;
        }
    }
}

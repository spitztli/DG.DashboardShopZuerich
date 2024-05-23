namespace DG.DashboardShopZuerich.Models
{
    internal class Employees
    {
        // Attribute
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtstag { get; set; }

        // Konstruktor
        public JsonDataService(string name, string vorname, DateTime geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag;
        }
    }
}

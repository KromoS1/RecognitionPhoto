using System;

namespace Data
{
    public class Fillings
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public DateTime InstallationDate{ get; set; }
        public string Contract { get; set; }
        public int BusinessTrip{ get; set; }
        public string TypeFillings{ get; set; }
        public string InstallationLocation { get; set; }

        public Fillings(int number,DateTime installationDate, string contract, int businessTrip,
            string typeFillings, string installationLocation)
        {
            Number = number;
            InstallationDate = installationDate;
            Contract = contract;
            BusinessTrip = businessTrip;
            TypeFillings = typeFillings;
            InstallationLocation = installationLocation;
        }
    }
}


namespace Iterator.Ejm2
{
    /// <summary>
    /// Representa un candidato
    /// </summary>
    public class Candidate
    {

        private string Name;
        private string CertificationType;
        private string Location;

        public Candidate(string name, string certificationType, string location)
        {
            this.Name = name;
            this.CertificationType = certificationType;
            this.Location = location;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetCertificationType()
        {
            return CertificationType;
        }

        public void SetCertificationType(string certificationType)
        {
            this.CertificationType = certificationType;
        }

        public string GetLocation()
        {
            return Location;
        }

        public void setLocation(string location)
        {
            this.Location = location;
        }
    }

}

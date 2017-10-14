using System;
using Iterator.Ejm2;
namespace Iterator
{
    class Program2
    {
        static void Main(string[] args)
        {
            AllCandidates ac = new AllCandidates();
            String selectedCandidates = "Name — - Cert Type — - Location" + "\n"
                    + " — — — — — — — — — — — — — — — — — — — ";
            while (ac.HasNext())
            {
                Candidate c = (Candidate)ac.Next();
                selectedCandidates = selectedCandidates + "\n" + c.GetName()
                        + " - " + c.GetCertificationType() + " - "
                        + c.GetLocation();
            }
            Console.WriteLine(selectedCandidates);
            Console.ReadKey();
        }
    }
}


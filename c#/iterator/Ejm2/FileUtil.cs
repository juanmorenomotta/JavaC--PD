using System;
using System.Collections;
using System.IO;
namespace Iterator.Ejm2
{
    public class FileUtil
    {

        public ArrayList FileToArrayList(String file)
        {
            ArrayList v = new ArrayList();
            StreamReader objReader = new StreamReader("d:\\Candidates.txt");
            string sLine = "";

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                {
                    // almacena en un array de Strings
                    String[] campos = sLine.Split(',');
                    String name = campos[0].Trim();
                    String certificationType = campos[1];
                    String location = campos[2];

                    v.Add(new Candidate(name, certificationType, location));
                }
            }
            objReader.Close();
            return v;
        }

    }
}



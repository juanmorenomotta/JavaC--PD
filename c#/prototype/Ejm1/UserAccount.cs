using System;
using System.Collections;
namespace Prototype.Ejm1
{
    /// <summary>
    /// Cuenta de Usuario
    /// </summary>

    public class UserAccount : Prototype
    {
        private string UserName;
        private string Password;
        private string FirstName;
        private string LastName;
        private ArrayList permissions = new ArrayList();

        public UserAccount()
        {

        }
        public override string ToString()
        {
            string res = "UserName:" + UserName + " Password:" + Password + " Nombre:" + FirstName + " Apellidos:" + LastName + " Permisos:";
            foreach (Object obj in permissions)
            {
                res = res + ":" + (string)obj;
            }
            return res;

        }
        /// <summary>
        /// Retorna una copia superficial (shallow copy)
        /// </summary>
        /// <returns>Copia del objeto</returns>
        public override Prototype Clone()
        {
            //El método MemberwiseClone crea una copia superficial
            return (Prototype)this.MemberwiseClone();
        }

        public void SetUserName(string uName)
        {
            UserName = uName;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public void SetPassword(string pwd)
        {
            Password = pwd;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void SetFirstName(string name)
        {
            FirstName = name;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetLastName(string name)
        {
            LastName = name;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void SetPermissions(ArrayList rights)
        {
            permissions = rights;
        }

        public ArrayList GetPermissions()
        {
            return permissions;
        }
    }
}

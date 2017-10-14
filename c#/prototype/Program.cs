using System;
using System.Collections;
using Prototype.Ejm1;
namespace Prototype
{
    class Program
    {
        /// <summary>
        /// Creacion de objetos prototype.
        /// En primer lugar se crean dos objetos que representan los tipos de cuenta: Supervisor y
        /// AccountRep. Estas instancias se almacenan dentro de AccountPrototypeFactory,  como objetos 
        /// de prototipo. Esta es la única vez que los permisos se leen de los archivos de datos.
        /// Cada vez que un nueva cuenta tipo Supervisor AccountRep necesitan ser creadas, 
        /// el cliente invoca uno  de las métodos getSupervisor o getAccountRep de la clase 
        /// AccountPrototypeFactory. 
        /// En respuesta, AccountPrototypeFactory clona un objeto prototipo adecuado de tipo 
        /// UserAccount, y lo devuelve al cliente. Una vez que el clon UserAccou es recibido, 
        /// el cliente puede hacer los cambios necesarios, tales como el establecimiento del nuevo 
        /// nombre de usuario y contraseña
        /// </summary>
        /// <param name="args"></param>
        static void Main1(string[] args)
        {
            ArrayList supervisorPermissions = getPermissionsFromFile("supervisor.txt");
            UserAccount supervisor = new UserAccount();
            supervisor.SetPermissions(supervisorPermissions);

            ArrayList accountRepPermissions = getPermissionsFromFile("accountrep.txt");
            UserAccount accountRep = new UserAccount();
            accountRep.SetPermissions(accountRepPermissions);

            AccountPrototypeFactory factory = new AccountPrototypeFactory(
                    supervisor, accountRep);

            /* Using protype objects to create other user accounts */
            UserAccount newSupervisor = factory.GetSupervisor();
            newSupervisor.SetUserName("wpantoja");
            newSupervisor.SetFirstName("Libardo Pantoja");
            newSupervisor.SetLastName("Pantoja Yepez");
            newSupervisor.SetPassword("h4%84JDHFD");
            Console.WriteLine(newSupervisor);

            UserAccount anotherSupervisor = factory.GetSupervisor();
            anotherSupervisor.SetUserName("juanmanuelpv");
            anotherSupervisor.SetPassword("*/-dfd34");
            Console.WriteLine(anotherSupervisor);

            UserAccount newAccountRep = factory.GetAccountRep();
            newAccountRep.SetUserName("juanito");
            newAccountRep.SetPassword("fjd&5$$5");
            Console.WriteLine(newAccountRep);
            Console.ReadKey();

        }
        /// <summary>
        /// Por simplicidad no se leen los permisos del archivo, sino se establecen manualemente
        /// </summary>
        /// <param name="archivo">Nombre del archivo que contiene los permisos del usuario estilo linux</param>
        /// <returns>Lista de Permisos</returns>
        public static ArrayList getPermissionsFromFile(String archivo)
        {
            ArrayList permisos = new ArrayList();
            if (archivo.Equals("supervisor.txt"))
            {
                permisos.Add("RWX");
                permisos.Add("RWX");
                permisos.Add("RWX");
            }
            else
            {
                permisos.Add("R-X");
                permisos.Add("R-X");
                permisos.Add("R--");
            }
            return permisos;
        }
    }
}

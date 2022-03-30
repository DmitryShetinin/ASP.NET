using System;
using System.Data.OleDb;

namespace Swagger.Demo.Controllers
{
    public class Connected_to_BD
    {
        protected OleDbConnection _command;
        protected OleDbCommand _Mycommand;
        public Connected_to_BD()
        {
            _command = new OleDbConnection("Provider=SQLOLEDB;Data Source=DESKTOP-QR4Q5KK;Initial catalog=tablesforASP.NET;Integrated Security=SSPI");
            _Mycommand = _command.CreateCommand();
            try
            {
                _command.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}

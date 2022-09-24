using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Data
{
    public class User
    {
        User(int userId,string name,string password)
        {
            this.userId = userId;
            this.name = name;
            this.password = password;
        }

        private int userId { get; set; }
        private string name { get; set; }
        private string password { get; set; }
       // private List<Printer> printers { get; set; }

    }
}

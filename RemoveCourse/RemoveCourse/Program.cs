using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            Database db = new Database();
            View vw = new View();
            CertificateProgram cp = new CertificateProgram(db, vw);
        }

    }
}

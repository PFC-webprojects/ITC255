using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCourse
{
    /*  For simplicity's sake, this class, which stores an ArrayList
     *  as its core property, will take the place of an actual database
     *  in this project component sample.
     */  
    public class Database
    {
        //  This string array is here only as a convenient way to initialize the ArrayList.
        private string[] _coursesSource = {
            "ITC 110",
            "ITC 115",
            "ITC 134",
            "ITC 155",
            "ITC 162",
            "ITC 172",
            "ITC 205",
            "ITC 220",
            "ITC 222",
            "ITC 224",
            "ITC 226",
            "ITC 230",
            "ITC 240",
            "ITC 250",
            "ITC 255",
            "ITC 260",
            "ITC 262",
            "WEB 105",
            "WEB 110",
            "WEB 120",
            "WEB 150",
            "WEB 200",
            "WEB 202",
            "WEB 204"
        };
        public ArrayList Courses { get; set; }  //  The core property of this Database

        public Database()  //  Constructor method
        {
            Courses = new ArrayList();
            foreach (String item in _coursesSource)
            {
                Courses.Add(item);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCourse
{
    /*  This class serves only as an EventArgs class for
     *  the View.RemoveClicked event.
     */
    public class RemoveEventArgs : EventArgs
    {
        public string CourseName { get; }

        public RemoveEventArgs(string courseName)
        {
            CourseName = courseName;
        }
    }
}

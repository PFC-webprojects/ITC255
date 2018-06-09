using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCourse
{
    public class CertificateProgram
    {
        private Database db;
        private View vw;

        public CertificateProgram(Database db, View vw)  //  Constructor method
        {
            this.db = db;
            this.vw = vw;

            vw.RemoveClicked += OnRemoveClicked;  //  Make the method OnRemoveClicked a listener of the RemoveClicked event.

            vw.DisplayCourses(db.Courses);
            vw.ShowDialog();  //  Display the form View modally.
        }

        private void OnRemoveClicked(object sender, RemoveEventArgs eventArgs)
        {
            db.Courses.Remove(eventArgs.CourseName);
            vw.DisplayConfirmation(eventArgs.CourseName + "  has been removed.");
            vw.DisplayCourses(db.Courses);
        }

    }
}

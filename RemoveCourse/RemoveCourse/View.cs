using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveCourse
{
    public partial class View : Form
    {
        public event EventHandler<RemoveEventArgs> RemoveClicked;  //  Declaring this here is necessary for its use later on . . .

        public View()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RaiseRemoveClickedEvent(new RemoveEventArgs(lstCourses.Text));  //  A CertificateProgram object should be listening for this.
        }
        /*  Not sure whether it's important to have both this and the preceding method,
         *  or whether they could just as well be combined into one method, but this is
         *  the way the online example did it -- and one is private while the other is
         *  protected virtual -- so here it is ? ? ? . . .
         */
        protected virtual void RaiseRemoveClickedEvent(RemoveEventArgs eventArgs)
        {
            RemoveClicked?.Invoke(this, eventArgs);
        }

        public void DisplayCourses(ArrayList courses)
        {
            this.lstCourses.Items.Clear();
            foreach (String course in courses)
            {
                this.lstCourses.Items.Add(course);
            }

            this.btnRemove.Enabled  =  0 < courses.Count;
            this.lstCourses.SelectedIndex  =  0 < courses.Count ? 0 : -1;  //  a SelectedIndex of -1 means that no item is selected.
        }

        public void DisplayConfirmation(string message)
        {
            this.txtFeedback.Text = message;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

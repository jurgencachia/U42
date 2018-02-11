using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication
{
    [Serializable]
    public class StudentDetails : PersonDetails
    {
        public StudentDetails()
        {  }

        public StudentDetails(PersonDetailsForm form)
        {
            this.Populate(form);
        }


        public string Subject
        {
            get; set;
        }

        public string StudentClass
        {
            get; set;
        }

        public override PersonType getPersonType()
        {
            return PersonType.Student;
        }

        public override void Show(PersonDetailsForm form)
        {
            base.Show(form);

            form.studentSubjectTextBox.Text = this.Subject;
            form.classTextBox.Text = this.StudentClass;
        }

        public override void Populate(PersonDetailsForm form)
        {
            base.Populate(form);

            this.StudentClass = form.classTextBox.Text;
            this.Subject = form.studentSubjectTextBox.Text;
        }
    }
}
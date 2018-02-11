using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    [Serializable]
    public class TeacherDetails : PersonDetails
    {
        public TeacherDetails()
        { }

        public TeacherDetails(PersonDetailsForm form)
        {
            this.Populate(form);
        }

        private string subject;
        private double salary;
        private string class1;
        private string class2;
        private string class3;
        private string class4;
        private string class5;

        public string TeacherSubject
        {
            get; set;
        }

        public double Salary
        {
            get; set;
        }

        public string Class1
        {
            get; set;
        }

        public string Class2
        {
            get; set;
        }

        public string Class3
        {
            get; set;
        }

        public string Class4
        {
            get; set;
        }

        public int Class5
        {
            get; set;
        }

        public override PersonType getPersonType()
        {
            return PersonType.Teacher;
        }

        public override void Populate(PersonDetailsForm form)
        {
            base.Populate(form);

            try
            {
                this.TeacherSubject = form.teacherSubjectTextBox.Text;
                this.salary = double.Parse(form.salaryTextBox.Text);
                this.class1 = form.class1TextBox.Text;
                this.class2 = form.class2TextBox.Text;
                this.class3 = form.class3TextBox.Text;
                this.class4 = form.class4TextBox.Text;
                this.class5 = form.class5TextBox.Text;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Data Entered is in an incompatible format");
            }
        }

        public override void Show(PersonDetailsForm form)
        {
            base.Show(form);

            form.teacherSubjectTextBox.Text = this.TeacherSubject;
            form.salaryTextBox.Text = this.salary.ToString();
            form.class1TextBox.Text = this.class1;
            form.class2TextBox.Text = this.class2;
            form.class3TextBox.Text = this.class3;
            form.class4TextBox.Text = this.class4;
            form.class5TextBox.Text = this.class5;

            form.studentSubjectTextBox.Text = "";
            form.classTextBox.Text = "";
        }
    }


}
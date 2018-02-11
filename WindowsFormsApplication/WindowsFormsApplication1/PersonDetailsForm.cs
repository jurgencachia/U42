using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication
{
    public partial class PersonDetailsForm : Form
    {
        private Dictionary<string, PersonDetails> details;

        public PersonDetailsForm()
        {
            InitializeComponent();
        }

        public void OnClose(object sender, object args)
        {

        }

        private void LoadFiles()
        {
            try
            {
                if (File.Exists(PersonDetails.Path))
                {
                    using (FileStream file = new FileStream(PersonDetails.Path, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        this.details = (Dictionary<string, PersonDetails>)formatter.Deserialize(file);
                    }
                }
                else
                {
                    this.details = new Dictionary<string, PersonDetails>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveFiles()
        {
            try
            {

                using (FileStream file = new FileStream(PersonDetails.Path, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(file, this.details);
                    file.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveFiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadFiles();
        }


        private void SavePersonDetails(PersonDetails personDetails)
        {
            string id = personDetails.Id;

            if (this.details.ContainsKey(id))
            {
                this.details[id] = personDetails;
            }
            else
            {
                MessageBox.Show("This Person does not exists");
            }

            PersonDetailsForm.ClearInputFields(this);
        }

        private void CreatePersonDetails(PersonDetails personDetails)
        {
            string id = personDetails.Id;

            if (this.details.ContainsKey(id))
            {
                MessageBox.Show("This Person already exists");
            }
            else
            {
                this.details.Add(id, personDetails);
            }

            PersonDetailsForm.ClearInputFields(this);
        }

        private void createTeacherButton_Click(object sender, EventArgs e)
        {
            this.CreatePersonDetails(new TeacherDetails(this));
        }

        private void saveTeacherButton_Click(object sender, EventArgs e)
        {
            this.SavePersonDetails(new TeacherDetails(this));
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            this.CreatePersonDetails(new StudentDetails(this));
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            this.SavePersonDetails(new StudentDetails(this));
        }

        private void viewPersonButton_Click(object sender, EventArgs e)
        {
            string id = this.idTextBox.Text;

            if (this.details.ContainsKey(id))
            {
                this.details[id].Show(this);
            }
            else
            {
                MessageBox.Show("This Person does not exists");
            }
        }

        internal static void ClearInputFields(PersonDetailsForm form)
        {
            form.idTextBox.Text = "";
            form.nameTextBox.Text = "";
            form.addressTextBox.Text = "";
            form.dobMaskedTextBox.Text = "";
            form.contactMaskedTextBox.Text = "";

            form.teacherSubjectTextBox.Text = "";
            form.salaryTextBox.Text = "";
            form.class1TextBox.Text = "";
            form.class2TextBox.Text = "";
            form.class3TextBox.Text = "";
            form.class4TextBox.Text = "";
            form.class5TextBox.Text = "";

            form.studentSubjectTextBox.Text = "";
            form.classTextBox.Text = "";
        }
    }
}

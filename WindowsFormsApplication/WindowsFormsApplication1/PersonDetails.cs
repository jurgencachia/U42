using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication
{
    [Serializable]
    public abstract class PersonDetails
    {
        public PersonDetails()
        { }

        public const string Path = "./PersonDetailsFile.dat";

        public string Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public string DateOfBirth
        {
            get; set;
        }

        public string ContactNumber
        {
            get; set;
        }

        public abstract PersonType getPersonType();

        public virtual void Show(PersonDetailsForm form)
        {
            PersonDetailsForm.ClearInputFields(form);

            form.idTextBox.Text = this.Id;
            form.nameTextBox.Text = this.Name;
            form.addressTextBox.Text = this.Address;
            form.dobMaskedTextBox.Text = this.DateOfBirth;
            form.contactMaskedTextBox.Text = this.ContactNumber;
        }

        public virtual void Populate(PersonDetailsForm form)
        {
            this.Id = form.idTextBox.Text;
            this.Name = form.nameTextBox.Text;
            this.Address = form.addressTextBox.Text;
            this.DateOfBirth = form.dobMaskedTextBox.Text;
            this.ContactNumber = form.contactMaskedTextBox.Text;
        }

    }
}
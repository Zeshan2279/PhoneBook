using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBookCrud.Controllers
{
    public class AddContact
    {
        public Contact ContactAdd
        {
            get;set;
        }
        private String Action
        {
            get;set;
        }
        private String ContactNumber
        {
            get;set;
        }

        /**
         * Creates new form AddContactPanel
         */
        //public AddContactPanel(String ContactNumber, String Action)
        //{
        //    initComponents();

        //    this.action = Action;
        //    this.contactNumber = ContactNumber;
        //    if (Action.equals("Add"))
        //    {
        //        this.contact = new Contact();
        //        titleLbl.setText("Add New Contact");

        //    }
        //    else if (Action.equals("Edit"))
        //    {
        //        Contact c = PhoneBook.getIsntance().getContact(ContactNumber);
        //        this.contact = c;
        //        titleLbl.setText("Edit Contact");
        //        actionButton.setText("Update");
        //        nameTxtField.setText(c.getName());
        //        emailTxtField.setText(c.getEmail());
        //        contactTxtField.setText(c.getContactNumber());
        //        dateTxtField.setDate(c.getDob());

        //    }
        //    else if (Action.equals("Delete"))
        //    {
        //        Contact c = PhoneBook.getIsntance().getContact(ContactNumber);
        //        this.contact = c;
        //        titleLbl.setText("Delete a Contact");
        //        actionButton.setText("Delete");
        //        nameTxtField.setText(c.getName());
        //        emailTxtField.setText(c.getEmail());
        //        contactTxtField.setText(c.getContactNumber());
        //        dateTxtField.setDate(c.getDob());

        //        nameTxtField.setEnabled(false);
        //        emailTxtField.setEnabled(false);
        //        contactTxtField.setEnabled(false);
        //        dateTxtField.setEnabled(false);

        //    }

        //}

    }
}
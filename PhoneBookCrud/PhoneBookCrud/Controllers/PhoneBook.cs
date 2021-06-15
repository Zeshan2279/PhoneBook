using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PhoneBookCrud.Controllers
{
    public class PhoneBook
    {
        private static PhoneBook Instance
        {
            get; set;
        }

        private List<Contact> contacts
        {
            get; set;
        }

        private PhoneBook()
        {
            contacts = new List<Contact>();
        }

        public static PhoneBook GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PhoneBook();
            }

            return Instance;
        }

        public void AddContact(Contact c)
        {
            contacts.Add(c);
        }

        private int SearchContact(String number)
        {
            int index = -1;
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].ContactNumber.Equals(number))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public Contact GetContact(String number)
        {
            int index = SearchContact(number);
            return contacts[index];
        }

        public bool updateContact(String number, Contact c)
        {
            int index = SearchContact(number);

            if (index == -1)
            {
                return false;
            }
            else
            {
                contacts[index] = c;
                return true;
            }
        }

        public bool deleteContact(String number)
        {
            int index = SearchContact(number);

            if (index == -1)
            {
                return false;
            }
            else
            {
                contacts.RemoveAt(index);
                return true;
            }
        }



        public List<Contact> searchBasedOnEmail(String emailIdText)
        {
            List<Contact> searched = new List<Contact>();

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Email.Contains(emailIdText))
                {
                    searched.Add(contacts[i]);
                }
            }
            return searched;
        }

        public List<Contact> searchBasedOnName(String nameText)
        {
            List<Contact> searched = new List<Contact>();

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Name.Contains(nameText))
                {
                    searched.Add(contacts[i]);
                }
            }
            return searched;
        }

        public List<Contact> searchBasedOnContact(String contacText)
        {
            List<Contact> searched = new List<Contact>();

            for (int i = 0; i < contacts.Count(); i++)
            {
                if (contacts[i].ContactNumber.Contains(contacText))
                {
                    searched.Add(contacts[i]);
                }
            }
            return searched;
        }

        public void saveData(String filename)
        {
            try
            {
                StreamWriter fw = new StreamWriter(filename);


                fw.Write("Name,Email,Contact,Date Of Birth,Saved On\n");

                for (int i = 0; i < contacts.Count(); i++)
                {
                    fw.Write(contacts[i].Name + ", "
                            + contacts[i].Email + ","
                            + contacts[i].ContactNumber + ","
                            + contacts[i].Dob.ToString() + ","
                            + contacts[i].SavedOn.ToString() + "\n"
                    );
                }

                fw.Flush();
                fw.Close();
            }
            catch (Exception ex)
            {

            }

        }

        public void loadData(String filename)
        {
            try
            {
                StreamReader br = new StreamReader(filename);

                String line = br.ReadLine();

                line = br.ReadLine();
                while (line != null)
                {
                    Contact c = new Contact();
                    String[] toks = line.Split(',');

                    c.Name = toks[0];
                    c.Email = toks[1];
                    c.ContactNumber = toks[2];


                    DateTime d = Convert.ToDateTime(toks[3]);
                    c.Dob = d;
                    DateTime d1 = Convert.ToDateTime(toks[4]);
                    c.SavedOn = d1;
                    PhoneBook.GetInstance().AddContact(c);

                }

                br.Close();

            }
            catch (Exception ex)
            {

            }

        }
    }
}
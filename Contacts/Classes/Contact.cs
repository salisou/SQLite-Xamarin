using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Indirizzo { get; set; }
        [MaxLength(10)]
        public string Contatto { get; set; }
        public Contact()
        {
                
        }

    }
}

using Contacts.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Savebutton.Clicked += SaveButton_Clicked;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            #region Salva dati
            Contact contact = new Contact()
            {
                Nome = nameEnty.Text,
                Cognome = lastnameEnty.Text,
                Email = emailEnty.Text,
                Indirizzo = addresEnty.Text,
                Contatto = contactEnty.Text
            };
            #endregion

            #region Connezione SQLite 
            // qui faccio la connezione del sqlite di FilePath che ho creato prima 
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                //creazione della tabella
                conn.CreateTable<Contact>();
                //inserimento alla tabella contact creando una variabile chiamata rowAdded
                int rowAdded = conn.Insert(contact);


                // Chiudo la connezione 
                //conn.Close();
            }
            #endregion
        }
    }
}

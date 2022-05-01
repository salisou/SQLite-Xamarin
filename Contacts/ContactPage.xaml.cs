using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public object RemoveCommand { get; internal set; }

        public ContactPage()
        {
            InitializeComponent();
        }

        private void NewContactToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {

                // FARE quest sul progetto G3BCE per la creazione della tabella 
                conn.CreateTable<Contact>();
                var contact = conn.Table<Contact>().ToList();

                // chiamata della contactListView aggiunto in ContactPage.xaml,cs
                contactListView.ItemsSource = contact;
            }
        }

        protected void DeletBtton_clicked(object sender, EventArgs e)
        {

        }
    }
}
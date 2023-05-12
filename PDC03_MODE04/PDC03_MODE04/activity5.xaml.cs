using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        List<Contacts> contacts;
        public activity5()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }

        async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if(listView.SelectedItem != null)
            {
                var detailPage = new detailpage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await  Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name = "Juan Dela Cruz",
                Age = 30,
                Occupation = "Analyst",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "John Doe",
                Age = 25,
                Occupation = "Programmer",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Jane Doe",
                Age = 26,
                Occupation = "Tester",
                Country = "Philippines"
            });

          
        }
    }
}
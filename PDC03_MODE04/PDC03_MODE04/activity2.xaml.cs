using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees;  } }
        public activity2()
        {
            InitializeComponent();

            EmployeeView.ItemsSource= employees;
            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President" });
            employees.Add(new Employee { DisplayName = "John Doe", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Peter Cruz", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Mark Dela Cruz", Position = "Supervisor" });

        }

        private void Add_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
         
        private void Edit_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Delete_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
    }
}
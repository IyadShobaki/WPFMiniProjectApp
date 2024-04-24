using DemoLibrary;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace WPFMiniProject
{
   /// <summary>
   /// Interaction logic for PersonEntry.xaml
   /// </summary>
   public partial class PersonEntry : Window, ISaveAddress
   {
      BindingList<AddressModel> addresses = new BindingList<AddressModel>();


      public PersonEntry()
      {
         InitializeComponent();

         addressesListBox.ItemsSource = addresses;

         //addresses.Add(new AddressModel
         //{
         //   StreetAddress = "123 Wallabee Way",
         //   City = "Clarks Summit",
         //   State = "PA",
         //   ZipCode = "18411"
         //});
      }

      public void SaveAddress(AddressModel address)
      {
         addresses.Add(address);
      }

      private void addAddressButton_Click(object sender, RoutedEventArgs e)
      {
         AddressEntry entry = new AddressEntry(this);

         entry.Show();

      }

      private void savePersonButton_Click(object sender, RoutedEventArgs e)
      {
         PersonModel person = new PersonModel
         {
            FirstName = firstNameText.Text,
            LastName = lastNameText.Text,
            IsActive = (activeCheckBox.IsChecked ?? false),
            // the 2 question marks check if its null will put false value
            Addresses = addresses.ToList()
         };


      }
   }
}

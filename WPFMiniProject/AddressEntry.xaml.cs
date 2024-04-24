using DemoLibrary;
using System.Windows;

namespace WPFMiniProject
{
   /// <summary>
   /// Interaction logic for AddressEntry.xaml
   /// </summary>
   public partial class AddressEntry : Window
   {
      // Who ever call this class is implement ISaveAddress and will get 
      // address info adding to the list
      ISaveAddress _parent;
      public AddressEntry(ISaveAddress parent)
      {
         InitializeComponent();

         _parent = parent;
      }

      private void saveAddressButton_Click(object sender, RoutedEventArgs e)
      {
         AddressModel address = new AddressModel
         {
            StreetAddress = streetAddressText.Text,
            City = cityText.Text,
            State = stateText.Text,
            ZipCode = zipCodeText.Text
         };

         _parent.SaveAddress(address);

         this.Close();
      }
   }
}

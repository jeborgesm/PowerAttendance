using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace PowerAttendance
{
    /// <summary>
    /// Interaction logic for MemberData.xaml
    /// </summary>
    public partial class MemberData : Window
    {
        public MemberData()
        {
            InitializeComponent();
        }

        private void btnLoadPic_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                UserPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void txtState_Copy_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource memberViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("memberViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
             //memberViewSource.Source =  [generic data source]
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //_context.SaveChanges();
        }
    }
}

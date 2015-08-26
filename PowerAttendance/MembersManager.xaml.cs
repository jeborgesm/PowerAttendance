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
using System.Windows.Shapes;
using System.Reflection;
using System.Runtime.InteropServices;


namespace PowerAttendance
{
    /// <summary>
    /// Interaction logic for MembersManager.xaml
    /// </summary>
    public partial class MembersManager : Window
    {
        AttendanceRegistryModel _context = new AttendanceRegistryModel();
        public MembersManager()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource memberViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("memberViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // memberViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource paymentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("paymentViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // paymentViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource attendanceViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("attendanceViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // attendanceViewSource.Source = [generic data source]

            _context.Members.ToList();
            //_context.Attendances.ToList();
            //_context.Payments.ToList();

            memberViewSource.Source = _context.Members.Local;
            paymentViewSource.Source = _context.Payments.Local;
            attendanceViewSource.Source = _context.Attendances.Local;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            // Refresh the grids so the database generated values show up. 
            this.memberDataGrid.Items.Refresh();
            this.attendancesDataGrid.Items.Refresh();
            this.paymentsDataGrid.Items.Refresh();

            MessageBox.Show("Información guardada.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
        }




        private void AddAttendance_Click(object sender, RoutedEventArgs e)
        {

            var member = (Member)memberDataGrid.SelectedItem;
            member.Attendances.Add(new Attendance { AttendanceDate = DateTime.Now });
            this.attendancesDataGrid.Items.Refresh();

            //var data = new Attendance {  AttendanceDate = DateTime.Now, Member = (Member)memberDataGrid.SelectedItem  };

            //this.attendancesDataGrid.Items.Add(data);
        }
    }
}

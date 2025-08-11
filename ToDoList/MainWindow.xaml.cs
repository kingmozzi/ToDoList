using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.View;
using ToDoList.ViewModel;


namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Open Add Modal
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Exit
            Close();
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            //Open Caledar Modal
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.ShowDialog();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
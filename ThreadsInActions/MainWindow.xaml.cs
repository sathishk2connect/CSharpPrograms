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
using System.Threading;
using System.Windows.Threading;

namespace ThreadsInActions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count;
        Action action;
        ThreadStart threadMethod;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void CountCharacters()
        {
            Thread.Sleep(5000);
            int countValue = 324098;
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Normal,
                   new Action(() => lblStatus.Content = countValue.ToString() + " characters in file"));
        }

        private void btnFileProcess_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(CountCharacters));
            lblStatus.Content = "Processing....";
            t.Start();
        }
    }
}

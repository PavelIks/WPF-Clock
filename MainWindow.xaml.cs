using System;
using System.Windows;
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1.0);
            timer.Start();
            timer.Tick += new EventHandler(delegate (object s, EventArgs a)
            {
                Tuch.Content = "" + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
            });
        }
    }
}
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordBoxMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var vm = new PasswordViewModel();
            this.DataContext = vm;

            InitializeComponent();
        }

        private void MyPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pBox = sender as PasswordBox;
            PasswordBoxMVVMAttachedProperties.SetEncryptedPassword(pBox, pBox.SecurePassword);

            
        }

        private void PasswordBox_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pBox = sender as PasswordBox;

            if (pBox.IsEnabled == false)
            {
                RoutedEventArgs eventArgs = new RoutedEventArgs(PasswordBoxAttachedEvent.HasBeenDisabledEvent);
                pBox.RaiseEvent(eventArgs);
            }
            if (pBox.IsEnabled == true)
            {
                RoutedEventArgs eventArgs = new RoutedEventArgs(PasswordBoxAttachedEvent.HasBeenEnabledEvent);
                pBox.RaiseEvent(eventArgs);
            }
        }
    }
}

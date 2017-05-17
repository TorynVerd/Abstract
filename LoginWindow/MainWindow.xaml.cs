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

namespace LoginWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

        
        private void Enter_Text(object sender, EventArgs e)
        {
            if (Login.Text.Length == 0) 
            {
                Login.Text = "";
                First.Text = "";
                Login.ToolTip = "True";
            }

           
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text.Length == 0)
            {
                Login.Text = "";
                First.Text = "Login";
            }

        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pb = sender as PasswordBox;
            pb.Tag = string.IsNullOrEmpty(pb.Password);
            if (!(bool)pb.Tag)
            {
                Second.Text = "";
                Pass.ToolTip = "True";
            }
            else
            {
                Second.Text = "Password";
            }
        }


    }
}

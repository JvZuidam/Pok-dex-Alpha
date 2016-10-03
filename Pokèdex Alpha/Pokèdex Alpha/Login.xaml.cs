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
using Pokèdex_Alpha.Classes;

namespace Pokèdex_Alpha
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window2 win1 = new Window2();
            win1.Show();
            this.Close();
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            var name = TxtUsrLog.Text;
            var password = TxtPswdLog.Text;

            //create a new instance of the SendData class
            SendData logitems = new SendData {LogName = name, LogPass = password};
        }
    }
}
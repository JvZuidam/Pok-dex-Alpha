using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Create variables for the textbox elements
            var name = TxtNm.Text;
            var username = TxtUsrNm.Text;
            var password = TxtPswd.Password;
            var passwordRepeat = TxtPswdRpt.Password;
            var email = TxtEml.Text;

            //create a new instance of the SendData class
            SendData regitems = new SendData { RegName = name, RegUsername = username, RegPass = password, RegPassRpt = passwordRepeat, RegEmail = email};


            //Run a bunch of if statements to find out if the user has not filled out one or more of the forms.
            //Return a messagebox telling the user which form(s) they still have to fill in.
            //Following the order of: Name, Username, Email, Password, repeated password.
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(this, "You did not enter a name" + (string.IsNullOrWhiteSpace(username) ? " and username" : "") + (string.IsNullOrWhiteSpace(email) ? " and email" : "") + (string.IsNullOrWhiteSpace(password) ? " and password" : "") + (string.IsNullOrWhiteSpace(passwordRepeat) ? " and the repeated password" : ""));
                return;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(this, "You did not enter a username" + (string.IsNullOrWhiteSpace(email) ? " and email" : "") + (string.IsNullOrWhiteSpace(password) ? " and password" : "") + (string.IsNullOrWhiteSpace(passwordRepeat) ? " and the repeated password" : ""));
                return;
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(this, "You did not enter an email" + (string.IsNullOrWhiteSpace(password) ? " and password" : "") + (string.IsNullOrWhiteSpace(passwordRepeat) ? " and the repeated password" : ""));
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(this, "You did not enter a password" + (string.IsNullOrWhiteSpace(passwordRepeat) ? " and the repeated password" : ""));
                return;
            }
            else if (string.IsNullOrWhiteSpace(passwordRepeat))
            {
                MessageBox.Show(this, "You did not enter the repeated password");
                return;
            }
            //When all froms are filled run a few validation checks
            //Hash and salt the password
            //Send all the data to the database
            else
            {
                //Check with the help of the email validation class if the user entered a valid email address.
                EmailValidation Email = new EmailValidation();
                if (Email.IsValidEmail(email))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

                // Check if the password and repeated password are the same
                if (password == passwordRepeat)
                {
                    Console.WriteLine("Same");
                }
                else
                {
                    Console.WriteLine("Different");
                }
                //Hash and salt the entered password.
                var Hash = Hashing.CreateHash(password);
                Console.WriteLine(Hash);
                regitems.RegHash = Hash;
            }
            Console.WriteLine("Succesful");
            regitems.SendRegister();
        }
    }
}
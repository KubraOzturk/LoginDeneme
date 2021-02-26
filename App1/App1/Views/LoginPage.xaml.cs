using App1.Droid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Droid.Models;

namespace App1.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
         
            ActivitiySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            entry_username.Completed += (s, e) => entry_password.Focus();
            entry_password.Completed += (s, e) => SignIn(s, e);
        }
        void SignIn(object sender, EventArgs e)
        {
            User user = new User(entry_username.Text,entry_password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success","Okey");
            }
            else
            {
                DisplayAlert("Login", "Login Not Corrext,empty username or password", "Okey");
            }
        }
    }
}
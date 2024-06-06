using EcoCenter_Group5.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EcoCenter_Group5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void CRUDPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowActionPage());
        }
       
    }
}

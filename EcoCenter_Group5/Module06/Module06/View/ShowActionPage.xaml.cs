using EcoCenter_Group5.Model;
using EcoCenter_Group5.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoCenter_Group5.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowActionPage : ContentPage
    {
        ActionViewModel viewModel;
        public ShowActionPage()
        {
            InitializeComponent();
            viewModel = new ActionViewModel();
        }
        private void showActionPage()
        {
            var res = viewModel.GetAllActions().Result;
            lstData.ItemsSource = res;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            showActionPage();
        }
        private void btnAddRecord(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ActionView());
        }
        private async void lsData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ActionModel obj = (ActionModel)e.SelectedItem;
                string res = await DisplayActionSheet("Operation", "Cancel", null, "Update", "Delete");
                switch (res)
                {
                    case "Update":
                        await this.Navigation.PushAsync(new ActionView(obj));
                        break;
                    case "Delete":
                        viewModel.DeleteAction(obj);
                        showActionPage();
                        break;
                }
                lstData.SelectedItem = null;
            }
        }
        private async void HOMEPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
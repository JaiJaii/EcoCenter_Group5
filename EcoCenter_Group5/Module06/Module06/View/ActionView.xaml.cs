using EcoCenter_Group5.Model;
using EcoCenter_Group5.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace EcoCenter_Group5.View
{
    public partial class ActionView : ContentPage
    {
        ActionViewModel _viewModel;
        bool _isUpdate;
        int actionID;

        public ActionView()
        {
            InitializeComponent();
            _viewModel = new ActionViewModel();
            _isUpdate = false;
        }

        public ActionView(ActionModel obj)
        {
            InitializeComponent();
            _viewModel = new ActionViewModel();
            if (obj != null)
            {
                actionID = obj.Id;
                txtDescription.Text = obj.Description;
                _isUpdate = true;

                if (txtImpactLevel.ItemsSource is IList<string> impactlvl && impactlvl.Any())
                {
                    txtImpactLevel.SelectedItem = impactlvl.FirstOrDefault(c => c == obj.ImpactLevel);
                }

                if (txtFrequency.ItemsSource is IList<string> frequency && frequency.Any())
                {
                    txtFrequency.SelectedItem = frequency.FirstOrDefault(c => c == obj.Frequency);
                }
            }
        }

        private async void btnSaveUpdate_Clicked(object sender, EventArgs e)
        {
            ActionModel obj = new ActionModel
            {
                Description = txtDescription.Text,
                Category = txtCategory.Text,
                ImpactLevel = (string)txtImpactLevel.SelectedItem,
                Frequency = (string)txtFrequency.SelectedItem
            };

            if (_isUpdate)
            {
                obj.Id = actionID;
                await _viewModel.UpdateAction(obj);
            }
            else
            {
                _viewModel.InsertAction(obj);
            }

            await Navigation.PopAsync();
        }
    }
}

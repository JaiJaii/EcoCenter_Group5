using EcoCenter_Group5;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoCenter_Group5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionPage : ContentPage
    {
        ObservableCollection<Action> actions = new ObservableCollection<Action>();
        public ObservableCollection<Action> Actions { get { return actions; } }
        public CollectionPage()
        {
            InitializeComponent();
            ActionView.ItemsSource = actions;

            actions.Add(new Action
            {
                ActionCode = "E001",
                Description = "Unplug electrical sockets when not in use.",
                Category = "Energy",
                ImpactLevel = "Low (should help save 2Kw/h)",
                Frequency = "Daily",
                //Image = ""
            });


            actions.Add(new Action
            {
                ActionCode = "W002",
                Description = "Segregate trash wisely.",
                Category = "Waste",
                ImpactLevel = "des.",
                Frequency = "des.",
                //Image = ""
            });

            actions.Add(new Action
            {
                ActionCode = "aa",
                Description = "des.",
                Category = "des.",
                ImpactLevel = "des.",
                Frequency = "des.",
                //Image = ""
            });

        }
        private void Btn_DisplayAlert(object sender, EventArgs e)
        {
            DisplayAlert("Collection View", "This is a collection view", "OK");
        }
    }
}
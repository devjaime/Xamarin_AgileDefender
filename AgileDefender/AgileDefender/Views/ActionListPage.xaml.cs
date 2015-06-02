using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AgileDefender.ViewModels;
using AgileDefender.Helpers;
using AgileDefender.Models;

namespace AgileDefender.Views
{
    public partial class ActionListPage : ContentPage
    {
        private ActionViewModel vm;

        public ActionListPage()
        {
            InitializeComponent();

            this.Title = PageResources.DefaultPageTitle;
            vm = new ActionViewModel();
            this.BindingContext = vm;

            actionListView.ItemTapped += actionListView_ItemTapped;
        }

        private void actionListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e != null)
            {
                var actionSelected = e.Item as AgileAction;
                if (actionSelected != null)
                {
                    var a = actionSelected;
                }
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}

using App1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Person : ContentPage
    {

        private User user;
        public Person(User user) : base()
        {
            InitializeComponent();
            this.user = user;
            this.Title = user.name;

            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            var topLeft = new Label
            {
                Text = "Номер цеха: " + user.workshopNumber.ToString(), 
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            var bottomLeft = new Label
            {
                Text = "Ранг: " + user.rank.ToString(),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            grid.Children.Add(topLeft, 0, 0);
            grid.Children.Add(bottomLeft, 0, 1);

            Content = grid;
        }
    }
}
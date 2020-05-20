using App1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private List<User> users = new List<User>();
        public MainPage()
        {
            InitializeComponent();

            users.Add(new User("Katya", 1, 3));
            users.Add(new User("Yuri", 1, 2));
            users.Add(new User("Egor", 2, 1));
            users.Add(new User("Anton", 2, 3));
            var grid = new Grid();

            var header1 = new Label {
                Text = "Имя",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            var header2 = new Label {
                Text = "Подробности",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.Children.Add(header1, 0, 0);
            grid.Children.Add(header2, 1, 0);

            int cnt = 1;
            foreach (User user in users) {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                this.addRow(grid, user, cnt++);
            }
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Auto) });
            Content = grid;
        }

        private void addRow(Grid grid, User user, int line)
        {
            Button buttonAbout = new Button { 
                Text = "Подробнее",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 10
            };

            buttonAbout.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Person(user));
            };

            grid.Children.Add(new Label { 
                Text = user.name,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            }, 0, line);

            grid.Children.Add(buttonAbout, 1, line);
        }
    }
}

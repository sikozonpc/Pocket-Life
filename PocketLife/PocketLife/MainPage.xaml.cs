using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketLife.WeatherAPI;
using Xamarin.Forms;
using XamForms.Controls;

namespace PocketLife
{
    public partial class MainPage : TabbedPage
    {
        private Button[] buttons = new Button[9];
        private Label[] labels = new Label[9];
        private Entry[] entrys = new Entry[9];

        public MainPage()
        {
            InitializeComponent();

            buttons[0] = this.FindByName<Button>("currentWeather");

            entrys[0] = this.FindByName<Entry>("cityNameEntry");

            labels[0] = currentTemperature;
            labels[1] = this.FindByName<Label>("descriptionTemp");
            labels[2] = this.FindByName<Label>("windInfo");
            labels[3] = this.FindByName<Label>("pressureInfo");
            labels[4] = this.FindByName<Label>("humidtyInfo");
            labels[5] = this.FindByName<Label>("sunriseInfo");


            Calendar calendar = new Calendar()
            {
                WidthRequest = 300,
                HeightRequest = 300,
                BorderWidth = 1,
                BorderColor = Color.Green,
                SelectedBorderWidth = 2,
                SelectedBorderColor = Color.IndianRed,
                StartDay = DayOfWeek.Sunday,
                StartDate = DateTime.Now,
                ShowNumberOfWeek = true 
            };
            
            // Sets Today's date as a special day
            calendar.SpecialDates.Add(new SpecialDate(DateTime.Now) { BackgroundColor = Color.GhostWhite, TextColor = Color.Red, BorderColor = Color.DarkRed, BorderWidth = 2 });
            calendar.RaiseSpecialDatesChanged();
            

            calendar.DateClicked += (object sender, DateTimeEventArgs e) =>
            {
                var dateSelect = calendar.SelectedDate;
            };
            calendar.Focused += (object sender, FocusEventArgs e) =>
            {
                e.VisualElement.BackgroundColor = Color.Aqua;
            };
        }

        private void getWeatherButton_Clicked(object sender, EventArgs e)
        {
            WeatherClass weatherClass = new WeatherClass();

            WeatherJsonModel.Root jsonData = weatherClass.getWeatherData(entrys[0].Text);
            WeatherModel model = weatherClass.convertData(jsonData);

            labels[0].Text = model.CurrentTemperature.ToString() + " ºC" + " now";
            labels[1].Text = model.Description;
            labels[2].Text = model.WindSpeed.ToString() + " from " + model.WindAngle.ToString();
            labels[3].Text = model.Pressure.ToString() + " pA";
            labels[4].Text = model.Humidity.ToString() + " %";
            labels[5].Text = model.Sunrise.ToString();
        }



}
}

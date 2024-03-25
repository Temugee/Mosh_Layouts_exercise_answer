using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid_exercise_mosh
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RelativeLayoutExercise();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

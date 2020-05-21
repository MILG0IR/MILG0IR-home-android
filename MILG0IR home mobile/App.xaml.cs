using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MILG0IR_home_mobile {
    public partial class App : Application {
        public App() {
            InitializeComponent();
            MainPage = new MG_splash();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}

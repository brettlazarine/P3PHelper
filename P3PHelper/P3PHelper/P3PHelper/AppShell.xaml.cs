using System;
using Xamarin.Forms;

namespace P3PHelper
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routing section for SLink pages
            #region
            Routing.RegisterRoute("SLinks/AeonPage", typeof(P3PHelper.Views.SLinks.AeonPage));
            Routing.RegisterRoute("SLinks/ChariotPage", typeof(P3PHelper.Views.SLinks.ChariotPage));
            Routing.RegisterRoute("SLinks/DeathPage", typeof(P3PHelper.Views.SLinks.DeathPage));
            Routing.RegisterRoute("SLinks/DevilPage", typeof(P3PHelper.Views.SLinks.DevilPage));
            Routing.RegisterRoute("SLinks/EmperorPage", typeof(P3PHelper.Views.SLinks.EmperorPage));
            Routing.RegisterRoute("SLinks/EmpressPage", typeof(P3PHelper.Views.SLinks.EmpressPage));
            Routing.RegisterRoute("SLinks/FoolPage", typeof(P3PHelper.Views.SLinks.FoolPage));
            Routing.RegisterRoute("SLinks/FortunePage", typeof(P3PHelper.Views.SLinks.FortunePage));
            Routing.RegisterRoute("SLinks/HangedManPage", typeof(P3PHelper.Views.SLinks.HangedManPage));
            Routing.RegisterRoute("SLinks/HermitPage", typeof(P3PHelper.Views.SLinks.HermitPage));
            Routing.RegisterRoute("SLinks/HierophantPage", typeof(P3PHelper.Views.SLinks.HierophantPage));
            Routing.RegisterRoute("SLinks/JudgementPage", typeof(P3PHelper.Views.SLinks.JudgementPage));
            Routing.RegisterRoute("SLinks/JusticePage", typeof(P3PHelper.Views.SLinks.JusticePage));
            Routing.RegisterRoute("SLinks/LoversPage", typeof(P3PHelper.Views.SLinks.LoversPage));
            Routing.RegisterRoute("SLinks/MagicianPage", typeof(P3PHelper.Views.SLinks.MagicianPage));
            Routing.RegisterRoute("SLinks/MoonPage", typeof(P3PHelper.Views.SLinks.MoonPage));
            Routing.RegisterRoute("SLinks/PriestessPage", typeof(P3PHelper.Views.SLinks.PriestessPage));
            Routing.RegisterRoute("SLinks/StarPage", typeof(P3PHelper.Views.SLinks.StarPage));
            Routing.RegisterRoute("SLinks/StrengthPage", typeof(P3PHelper.Views.SLinks.StrengthPage));
            Routing.RegisterRoute("SLinks/SunPage", typeof(P3PHelper.Views.SLinks.SunPage));
            Routing.RegisterRoute("SLinks/TemperancePage", typeof(P3PHelper.Views.SLinks.TemperancePage));
            Routing.RegisterRoute("SLinks/TowerPage", typeof(P3PHelper.Views.SLinks.TowerPage));
            #endregion
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

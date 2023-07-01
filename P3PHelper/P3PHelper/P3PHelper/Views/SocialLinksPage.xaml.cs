using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P3PHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SocialLinksPage : ContentPage
    {
        public SocialLinksPage()
        {
            InitializeComponent();
        }

        //Button section for each Clicked SLink
        #region
        private async void Aeon_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/AeonPage");
        }
        private async void Chariot_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/ChariotPage");
        }
        private async void Death_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/DeathPage");
        }
        private async void Devil_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/DevilPage");
        }
        private async void Emperor_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/EmperorPage");
        }
        private async void Empress_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/EmpressPage");
        }
        private async void Fool_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/FoolPage");
        }
        private async void Fortune_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/FortunePage");
        }
        private async void HangedMan_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/HangedManPage");
        }
        private async void Hermit_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/HermitPage");
        }
        private async void Hierophant_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/HierophantPage");
        }
        private async void Judgement_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/JudgementPage");
        }
        private async void Justice_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/JusticePage");
        }
        private async void Lovers_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/LoversPage");
        }
        private async void Magician_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/MagicianPage");
        }
        private async void Moon_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/MoonPage");
        }
        private async void Priestess_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/PriestessPage");
        }
        private async void Star_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/StarPage");
        }
        private async void Strength_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/StrengthPage");
        }
        private async void Sun_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/SunPage");
        }
        private async void Temperance_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/TemperancePage");
        }
        private async void Tower_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("./SLinks/TowerPage");
        }
        #endregion
    }
}
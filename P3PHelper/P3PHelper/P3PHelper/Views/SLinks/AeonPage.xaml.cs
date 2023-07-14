using P3PHelper.Models;
using P3PHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P3PHelper.Views.SLinks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeonPage : ContentPage
    {
        public AeonPage()
        {
            InitializeComponent();
            BindingContext = new SLinksViewModel().CreateAeonInstance();
            AddRankLabels();
        }
        private void AddRankLabels()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                foreach (var rankUp in sLink.FemRankUps)
                {
                    var rankLabel = new Label { Text = $"Rank {rankUp.RankNumber}" };
                    RankUpsContainer.Children.Add(rankLabel);

                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label { Text = "Question" };
                        var questionLabel = new Label { Text = question };
                        var answerLabel = new Label { Text = answer };
                        RankUpsContainer.Children.Add(newQuestion);
                        RankUpsContainer.Children.Add(questionLabel);
                        RankUpsContainer.Children.Add(answerLabel);
                    }
                }
            }
        }
    }
}
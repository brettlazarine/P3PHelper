using P3PHelper.Controls;
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
            AddMaleRankLabels();
            AddFemaleRankLabels();
        }

        private void AddMaleRankLabels()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                foreach (var rankUp in sLink.MaleRankUps)
                {
                    var rankLabel = new Label { Text = $"Rank {rankUp.RankNumber}" };
                    var checkbox = new CustomCheckBox { Gender = "Male", IsChecked = rankUp.IsCompleted };
                    MaleRankUpsContainer.Children.Add(rankLabel);
                    MaleRankUpsContainer.Children.Add(checkbox);

                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label { Text = "Question", HorizontalOptions = LayoutOptions.Center };
                        var questionLabel = new Label { Text = question };
                        var answerLabel = new Label { Text = answer };
                        MaleRankUpsContainer.Children.Add(newQuestion);
                        MaleRankUpsContainer.Children.Add(questionLabel);
                        MaleRankUpsContainer.Children.Add(answerLabel);
                    }
                }
            }
        }
        private void AddFemaleRankLabels()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                foreach (var rankUp in sLink.FemRankUps)
                {
                    var rankLabel = new Label { Text = $"Rank {rankUp.RankNumber}" };
                    var checkbox = new CustomCheckBox { Gender = "Female", IsChecked = rankUp.IsCompleted };
                    FemaleRankUpsContainer.Children.Add(rankLabel);
                    FemaleRankUpsContainer.Children.Add(checkbox);

                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label { Text = "Question" };
                        var questionLabel = new Label { Text = question };
                        var answerLabel = new Label { Text = answer };
                        FemaleRankUpsContainer.Children.Add(newQuestion);
                        FemaleRankUpsContainer.Children.Add(questionLabel);
                        FemaleRankUpsContainer.Children.Add(answerLabel);
                    }
                }
            }
        }
    }
}
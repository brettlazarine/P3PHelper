using P3PHelper.Controls;
using P3PHelper.Models;
using P3PHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

        private Dictionary<int, bool> checkboxStates = new Dictionary<int, bool>();

        private void AddMaleRankLabels()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                foreach (var rankUp in sLink.MaleRankUps)
                {
                    var rankLabel = new Label { Text = $"Rank {rankUp.RankNumber}" };
                    var checkbox = new CustomCheckBox { Gender = "Male", IsChecked = GetCheckboxState(rankUp.RankNumber) };

                    checkbox.CheckedChanged += (sender, e) =>
                    {
                        rankUp.IsCompleted = e.Value;
                        SaveCheckboxState(rankUp.RankNumber, e.Value); // Save checkbox state
                    };

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
                    var checkbox = new CustomCheckBox { Gender = "Female", IsChecked = GetCheckboxState(rankUp.RankNumber) };

                    checkbox.CheckedChanged += (sender, e) =>
                    {
                        rankUp.IsCompleted = e.Value;
                        SaveCheckboxState(rankUp.RankNumber, e.Value); // Save checkbox state
                    };

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

        private bool GetCheckboxState(int rankNumber)
        {
            // Retrieve checkbox state from Application Properties
            if (Application.Current.Properties.ContainsKey($"CheckboxState_{rankNumber}"))
            {
                return (bool)Application.Current.Properties[$"CheckboxState_{rankNumber}"];
            }
            return false;
        }

        private void SaveCheckboxState(int rankNumber, bool state)
        {
            // Save checkbox state to Application Properties
            Application.Current.Properties[$"CheckboxState_{rankNumber}"] = state;
            Application.Current.SavePropertiesAsync();
        }
    }
}
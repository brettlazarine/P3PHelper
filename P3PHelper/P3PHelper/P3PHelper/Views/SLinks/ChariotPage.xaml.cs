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
    public partial class ChariotPage : ContentPage
    {
        public ChariotPage()
        {
            InitializeComponent();
            BindingContext = new SLinksViewModel().CreateChariotInstance();
            MaleNeedsPersona();
            FemaleNeedsPersona();
            AddMaleRankLabels();
            AddFemaleRankLabels();
        }

        private Dictionary<int, bool> checkboxStates = new Dictionary<int, bool>();

        private void MaleNeedsPersona()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                if (sLink.MaleRequiresPersona || sLink.FemaleRequiresPersona)
                {
                    var personaLabel = new Label
                    {
                        Text = "A Persona IS required for faster rank-ups!",
                        TextColor = Color.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    };
                    MaleNeedPersonaContainer.Children.Add(personaLabel);
                }
                else
                {
                    var personaLabel = new Label { Text = "A Persona is NOT required for faster rank-ups, but you can use one if you would like." };
                    MaleNeedPersonaContainer.Children.Add(personaLabel);
                }
            }
        }

        private void FemaleNeedsPersona()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                if (sLink.MaleRequiresPersona || sLink.FemaleRequiresPersona)
                {
                    var personaLabel = new Label
                    {
                        Text = "A Persona IS required for faster rank-ups!",
                        TextColor = Color.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    };
                    FemaleNeedPersonaContainer.Children.Add(personaLabel);
                }
                else
                {
                    var personaLabel = new Label { Text = "A Persona is NOT required for faster rank-ups, but you can use one if you would like." };
                    FemaleNeedPersonaContainer.Children.Add(personaLabel);
                }
            }
        }

        private void AddMaleRankLabels()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                foreach (var rankUp in sLink.MaleRankUps)
                {
                    var rankLabel = new Label
                    {
                        Text = $"Rank {rankUp.RankNumber}",
                        FontSize = 25,
                        TextColor = Color.White,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold
                    };
                    var checkbox = new CustomCheckBox
                    {
                        Gender = "Male",
                        IsChecked = GetCheckboxState(rankUp.RankNumber)
                    };
                    checkbox.HorizontalOptions = LayoutOptions.Center;

                    checkbox.CheckedChanged += (sender, e) =>
                    {
                        rankUp.IsCompleted = e.Value;
                        SaveCheckboxState(rankUp.RankNumber, e.Value); // Save checkbox state
                    };

                    var rankLayout = new StackLayout
                    {
                        BackgroundColor = Color.Blue,
                        Padding = 5,
                        //HeightRequest = 300
                    };

                    var rankAndCheckStack = new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Orientation = StackOrientation.Horizontal
                    };

                    rankAndCheckStack.Children.Add(rankLabel);
                    rankAndCheckStack.Children.Add(checkbox);

                    rankLayout.Children.Add(rankAndCheckStack);

                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label
                        {
                            Text = "Question",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var newResponse = new Label
                        {
                            Text = "Response",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var questionLabel = new Label
                        {
                            Text = question,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        var answerLabel = new Label
                        {
                            Text = answer,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        rankLayout.Children.Add(newQuestion);
                        rankLayout.Children.Add(questionLabel);
                        rankLayout.Children.Add(newResponse);
                        rankLayout.Children.Add(answerLabel);
                    }

                    rankLayout.Children.Add(new BoxView
                    {
                        BackgroundColor = Color.Blue,
                        HeightRequest = 1,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    });

                    MaleRankUpsContainer.Children.Add(rankLayout); // Add the StackLayout to the MaleRankUpsContainer
                }
            }
        }


        private void AddFemaleRankLabels()
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                foreach (var rankUp in sLink.FemaleRankUps)
                {
                    var rankLabel = new Label
                    {
                        Text = $"Rank {rankUp.RankNumber}",
                        FontSize = 25,
                        TextColor = Color.White,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold
                    };
                    var checkbox = new CustomCheckBox
                    {
                        Gender = "Female",
                        IsChecked = GetCheckboxState(rankUp.RankNumber)
                    };
                    checkbox.HorizontalOptions = LayoutOptions.Center;

                    checkbox.CheckedChanged += (sender, e) =>
                    {
                        rankUp.IsCompleted = e.Value;
                        SaveCheckboxState(rankUp.RankNumber, e.Value); // Save checkbox state
                    };

                    var rankLayout = new StackLayout
                    {
                        BackgroundColor = Color.HotPink,
                        Padding = 5,
                        //HeightRequest = 200
                    };

                    var rankAndCheckStack = new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Orientation = StackOrientation.Horizontal
                    };

                    rankAndCheckStack.Children.Add(rankLabel);
                    rankAndCheckStack.Children.Add(checkbox);

                    rankLayout.Children.Add(rankAndCheckStack);

                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label
                        {
                            Text = "Question",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var newResponse = new Label
                        {
                            Text = "Response",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var questionLabel = new Label
                        {
                            Text = question,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        var answerLabel = new Label
                        {
                            Text = answer,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        rankLayout.Children.Add(newQuestion);
                        rankLayout.Children.Add(questionLabel);
                        rankLayout.Children.Add(newResponse);
                        rankLayout.Children.Add(answerLabel);
                    }

                    rankLayout.Children.Add(new BoxView
                    {
                        BackgroundColor = Color.HotPink,
                        HeightRequest = 1,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    });

                    FemaleRankUpsContainer.Children.Add(rankLayout); // Add the StackLayout to the FemaleRankUpsContainer
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
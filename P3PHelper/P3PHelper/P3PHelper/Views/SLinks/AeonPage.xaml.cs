using Newtonsoft.Json;
using P3PHelper.Controls;
using P3PHelper.Models;
using P3PHelper.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static P3PHelper.Controls.Serialization;

namespace P3PHelper.Views.SLinks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeonPage : ContentPage
    {

        public AeonPage()
        {
            InitializeComponent();
            var vm = new SLinksViewModel();
            var sLink = vm.CreateAeonInstance();
            BindingContext = sLink;
            MaleNeedsPersona();
            FemaleNeedsPersona();
            AddMaleRankLabels();
            AddFemaleRankLabels();
        }

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
                    var personaLabel = new Label
                    {
                        Text = "A Persona is NOT required for faster rank-ups, but you can use one if you would like.",
                        TextColor = Color.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    };
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
                    var personaLabel = new Label
                    {
                        Text = "A Persona is NOT required for faster rank-ups, but you can use one if you would like.",
                        TextColor = Color.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    };
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

                    var customCheckbox = new CustomCheckBox
                    {
                        BindingContext = rankUp, // Set the binding context to the rankUp instance
                        Color = Color.White
                    };
                    customCheckbox.SetBinding(CustomCheckBox.IsCheckedProperty, new Binding("IsCompleted")); // Bind to the IsCompleted property


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
                    rankAndCheckStack.Children.Add(customCheckbox);

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

                    var customCheckbox = new CustomCheckBox
                    {
                        BindingContext = rankUp, // Set the binding context to the rankUp instance
                        Color = Color.White
                    };
                    customCheckbox.SetBinding(CustomCheckBox.IsCheckedProperty, new Binding("IsCompleted")); // Bind to the IsCompleted property


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
                    rankAndCheckStack.Children.Add(customCheckbox);

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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var sLink = BindingContext as SLink;
            if (sLink == null)
            {
                // If the BindingContext is not of type SLink, we can't proceed.
                // You may want to handle this situation accordingly, such as showing an error message or logging.
                return;
            }

            // Retrieve the JSON string from Preferences
            string jsonData = Preferences.Get("rankUpData", "");

            try
            {
                if (!string.IsNullOrEmpty(jsonData))
                {
                    // Deserialize the JSON string back to the SLinkSerializedData instance
                    var serializedData = JsonConvert.DeserializeObject<SLinkSerializedData>(jsonData);

                    // Update the MaleRankUps collection
                    foreach (var rankUpData in serializedData.MaleRankUps)
                    {
                        var rankUp = sLink.MaleRankUps.FirstOrDefault(r => r.RankNumber == rankUpData.RankNumber);
                        if (rankUp != null)
                        {
                            rankUp.IsCompleted = rankUpData.IsCompleted;
                        }
                    }

                    // Update the FemaleRankUps collection
                    foreach (var rankUpData in serializedData.FemaleRankUps)
                    {
                        var rankUp = sLink.FemaleRankUps.FirstOrDefault(r => r.RankNumber == rankUpData.RankNumber);
                        if (rankUp != null)
                        {
                            rankUp.IsCompleted = rankUpData.IsCompleted;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception details
                // This can help you identify the cause of any potential issues during deserialization
                Console.WriteLine($"Exception during deserialization: {ex}");
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            var sLink = BindingContext as SLink;
            if (sLink == null)
            {
                // If the BindingContext is not of type SLink, we can't proceed.
                // You may want to handle this situation accordingly, such as showing an error message or logging.
                return;
            }

            // Create the SLinkSerializedData instance with the necessary data
            var serializedData = new SLinkSerializedData
            {
                MaleRankUps = sLink.MaleRankUps.Select(rankUp => new RankUpSerializedData
                {
                    RankNumber = rankUp.RankNumber,
                    IsCompleted = rankUp.IsCompleted
                }).ToList(),
                FemaleRankUps = sLink.FemaleRankUps.Select(rankUp => new RankUpSerializedData
                {
                    RankNumber = rankUp.RankNumber,
                    IsCompleted = rankUp.IsCompleted
                }).ToList()
            };

            // Save the SLinkSerializedData instance to the Preferences
            string jsonData = JsonConvert.SerializeObject(serializedData);
            Preferences.Set("rankUpData", jsonData);
        }

        private void Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = (CustomCheckBox)sender;
            var rankUp = checkbox.BindingContext as RankUp;
            rankUp.IsCompleted = e.Value;

            // Save the data as JSON string
            var vm = (SLinksViewModel)BindingContext;
            string jsonData = JsonConvert.SerializeObject(vm.SLinks);
            Preferences.Set("rankUpData", jsonData);
        }
    }
}

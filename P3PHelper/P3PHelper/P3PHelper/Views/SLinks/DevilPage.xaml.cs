using Newtonsoft.Json;
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
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;
using static P3PHelper.Controls.Serialization;

namespace P3PHelper.Views.SLinks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DevilPage : ContentPage
    {
        public DevilPage()
        {
            InitializeComponent();
            var vm = new SLinksViewModel();
            var sLink = vm.CreateDevilInstance();
            BindingContext = sLink;
            MaleNeedsPersona();
            FemaleNeedsPersona();
            AddMaleRankLabels();
            AddFemaleRankLabels();
        }

        private void MaleNeedsPersona() // Bool check, converts bool to string indicating requirements for Persona in SLinks
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                if (sLink.MaleRequiresPersona)
                {
                    var personaLabel = new Label
                    {
                        Text = "A Persona IS required for faster rank-ups!",
                        TextColor = Color.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    };
                    MaleNeedPersonaContainer.Children.Add(personaLabel); // Label for REQUIRED
                }
                else
                {
                    var personaLabel = new Label // Label for NOT required
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

        private void FemaleNeedsPersona() // Bool check, converts bool to string indicating requirements for Persona in SLinks
        {
            var sLink = BindingContext as SLink;
            if (sLink != null)
            {
                if (sLink.FemaleRequiresPersona)
                {
                    var personaLabel = new Label // Label for REQUIRED
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
                    var personaLabel = new Label // Label for NOT required
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
        /*
        
        MALE MC
        Create layouts and labels for each SLink rank
        Add blue color to implement a thematic link to the Male MC
        Checkbox placed next to RankNumber for aesthetic means of marking completion
        
        */
        private void AddMaleRankLabels()
        {
            var sLink = BindingContext as SLink; // Cast sLink so that it can be worked with below
            if (sLink != null) // Ensure sLink is not null to avoid exceptions
            {
                foreach (var rankUp in sLink.MaleRankUps) // MaleRankUps is a collection that requires iteration
                {
                    var rankLabel = new Label
                    {
                        Text = $"Rank {rankUp.RankNumber}",
                        FontSize = 25,
                        TextColor = Color.White,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold
                    };

                    var customCheckbox = new CustomCheckBox // Bind checkbox to rankUp
                    {
                        BindingContext = rankUp,
                        Color = Color.White
                    };
                    // Bind to IsCompleted property
                    customCheckbox.SetBinding(CustomCheckBox.IsCheckedProperty, new Binding("IsCompleted"));

                    // Create StackLayout for each SLink rank
                    var rankLayout = new StackLayout
                    {
                        BackgroundColor = Color.Blue,
                        Padding = 5,
                        //HeightRequest = 200
                    };

                    // Create StackLayout so that RankNumber and checkbox can be horizontally oriented
                    var rankAndCheckStack = new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Orientation = StackOrientation.Horizontal
                    };

                    // Add RankNumber and checkbox to their StackLayout
                    rankAndCheckStack.Children.Add(rankLabel);
                    rankAndCheckStack.Children.Add(customCheckbox);

                    // Add rankAndCheckStack to SLink rank StackLayout
                    rankLayout.Children.Add(rankAndCheckStack);

                    // Create labels for each question and response FOR EACH SLink rank level
                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label // Title label denoting the question text is below
                        {
                            Text = "Question",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var newResponse = new Label // Title label denoting the response text is below
                        {
                            Text = "Response",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var questionLabel = new Label // Label for the question text, derived from rankUp.Questions
                        {
                            Text = question,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        var answerLabel = new Label // Label for the response text, derived from rankUp.Questions
                        {
                            Text = answer,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        // Add question and response labels to the rankLayout
                        rankLayout.Children.Add(newQuestion);
                        rankLayout.Children.Add(questionLabel);
                        rankLayout.Children.Add(newResponse);
                        rankLayout.Children.Add(answerLabel);
                    }
                    // Adds a blue line between each SLink rank, may consider removing
                    rankLayout.Children.Add(new BoxView
                    {
                        BackgroundColor = Color.Blue,
                        HeightRequest = 1,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    });
                    // Add the StackLayout to the MaleRankUpsContainer
                    MaleRankUpsContainer.Children.Add(rankLayout);
                }
            }
        }
        /*
        
        FEMALE MC
        Create layouts and labels for each SLink rank
        Add blue color to implement a thematic link to the Male MC
        Checkbox placed next to RankNumber for aesthetic means of marking completion
        
        */
        private void AddFemaleRankLabels()
        {
            var sLink = BindingContext as SLink; // Cast sLink so that it can be worked with below
            if (sLink != null) // Ensure sLink is not null to avoid exceptions
            {
                foreach (var rankUp in sLink.FemaleRankUps) // FemaleRankUps is a collection that requires iteration
                {
                    var rankLabel = new Label
                    {
                        Text = $"Rank {rankUp.RankNumber}",
                        FontSize = 25,
                        TextColor = Color.White,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold
                    };

                    var customCheckbox = new CustomCheckBox // Bind checkbox to rankUp
                    {
                        BindingContext = rankUp,
                        Color = Color.White
                    };
                    // Bind to IsCompleted property
                    customCheckbox.SetBinding(CustomCheckBox.IsCheckedProperty, new Binding("IsCompleted"));

                    // Create StackLayout for each SLink rank
                    var rankLayout = new StackLayout
                    {
                        BackgroundColor = Color.HotPink,
                        Padding = 5,
                        //HeightRequest = 200
                    };

                    // Create StackLayout so that RankNumber and checkbox can be horizontally oriented
                    var rankAndCheckStack = new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Orientation = StackOrientation.Horizontal
                    };

                    // Add RankNumber and checkbox to their StackLayout
                    rankAndCheckStack.Children.Add(rankLabel);
                    rankAndCheckStack.Children.Add(customCheckbox);

                    // Add rankAndCheckStack to SLink rank StackLayout
                    rankLayout.Children.Add(rankAndCheckStack);

                    // Create labels for each question and response FOR EACH SLink rank level
                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        var newQuestion = new Label // Title label denoting the question text is below
                        {
                            Text = "Question",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var newResponse = new Label // Title label denoting the response text is below
                        {
                            Text = "Response",
                            HorizontalOptions = LayoutOptions.Center,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.White,
                            FontSize = 20
                        };
                        var questionLabel = new Label // Label for the question text, derived from rankUp.Questions
                        {
                            Text = question,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        var answerLabel = new Label // Label for the response text, derived from rankUp.Questions
                        {
                            Text = answer,
                            TextColor = Color.White,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontAttributes = FontAttributes.Italic
                        };
                        // Add question and response labels to the rankLayout
                        rankLayout.Children.Add(newQuestion);
                        rankLayout.Children.Add(questionLabel);
                        rankLayout.Children.Add(newResponse);
                        rankLayout.Children.Add(answerLabel);
                    }
                    // Adds a hotpink line between each SLink rank, may consider removing
                    rankLayout.Children.Add(new BoxView
                    {
                        BackgroundColor = Color.HotPink,
                        HeightRequest = 1,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    });
                    // Add the StackLayout to the FemaleRankUpsContainer
                    FemaleRankUpsContainer.Children.Add(rankLayout);
                }
            }
        }
        /*  
          
        Override OnAppearing() to restore the state of the checkboxes bound to RankUp.IsCompleted property
        Retrieves data from JSON string saved in Preferences
        Selects data from JSON based on Arcana
         
        */
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var sLink = BindingContext as SLink; // Cast sLink so that it can be worked with below
            if (sLink == null)
            {
                // If BindingContext is not of type SLink, display custom error message and return
                DisplayAlert("Oops!", "SLink data didn't come through.\nVerify instance properties!", "OK");
                return;
            }

            // Retrieve JSON string from Preferences for the RankUp properties, checkbox
            string jsonData = Preferences.Get($"rankUpData_Devil_{sLink.Arcana}", ""); // Use Arcana property from SLink as unique identifier

            try
            {
                if (!string.IsNullOrEmpty(jsonData))
                {
                    // Deserialize JSON string back to SLinkSerializedData instance
                    var serializedData = JsonConvert.DeserializeObject<SLinkSerializedData>(jsonData);

                    // Update MaleRankUps IsCompleted, checkbox for page 
                    foreach (var rankUpData in serializedData.MaleRankUps)
                    {
                        var rankUp = sLink.MaleRankUps.FirstOrDefault(r => r.RankNumber == rankUpData.RankNumber);
                        if (rankUp != null)
                        {
                            rankUp.IsCompleted = rankUpData.IsCompleted;
                        }
                    }

                    // Update FemaleRankUps IsCompleted, checkbox for page
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
                // Log exception details
                Console.WriteLine($"Exception during deserialization: {ex}");
            }
        }
        /*
          
        Override OnDisappearing() to save the state of the checkboxes bound to RankUp.IsCompleted property
        Saves data as JSON object in Preferences
        Saves data using Aracana as unique identifier
         
        */
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            var sLink = BindingContext as SLink; // Cast sLink so that it can be worked with below
            if (sLink == null)
            {
                // If BindingContext is not of type SLink, display custom error message and return
                DisplayAlert("Bad news!", "SLink data didn't save.\nVerify instance properties in Preferences!", "OK");
                return;
            }

            // Create SLinkSerializedData instance with MaleRankUps and FemaleRankUps properties
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

            // Save SLinkSerializedData instance to Preferences, save checkbox state for when the page or app are reloaded
            string jsonData = JsonConvert.SerializeObject(serializedData);
            Preferences.Set($"rankUpData_Devil_{sLink.Arcana}", jsonData); // Use Arcana property from SLink as unique identifier
        }
        /*
         
        Handles checkbox being checked
        Updates RankUp.IsCompleted property when the checkbox is checked
         
        */
        private void Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = (CustomCheckBox)sender; // Cast to access properties
            var rankUp = checkbox.BindingContext as RankUp; // Cast to access properties
            rankUp.IsCompleted = e.Value; // Update value
            // Save the data for current SLink page using unique Arcana property
            string jsonData = JsonConvert.SerializeObject(rankUp);
            var sLink = (SLink)this.BindingContext;
            Preferences.Set($"rankUpData_Devil_{sLink.Arcana}", jsonData);
        }
    }
}
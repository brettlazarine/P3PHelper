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

namespace P3PHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestsPage : ContentPage
    {
        public RequestsPage()
        {
            InitializeComponent();
            var vm = new RequestsViewModel();
            BindingContext = vm;
        }
        public void AddRequestLabels()
        {
            var request = BindingContext as Request;
            if (request != null)
            {
                foreach (var req in request.Requests)
                {
                    var requestLayout = new StackLayout
                    {
                        
                    };
                    var numberCheckboxArrowLayout = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };
                    var requestDetailsLayout = new StackLayout
                    {

                    };
                    var checkboxArrowLayout = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };

                    var customCheckbox = new CheckBox
                    {
                        Color = Color.White,
                        BindingContext = req
                    };
                    customCheckbox.SetBinding(CustomCheckBox.IsCheckedProperty, new Binding("IsCompleted"));

                    // Create arrow icon for toggling the collapsible content
                    var arrowIcon = new Image
                    {
                        Source = "downArrow.png",
                        HeightRequest = 20,
                        WidthRequest = 20,
                        VerticalOptions = LayoutOptions.Center
                    };
                    bool isArrowRotated = false; // Initializes arrow rotation to false
                    // Toggle visibility and rotation of the arrowIcon when numberCheckboxArrowLayout is tapped
                    numberCheckboxArrowLayout.GestureRecognizers.Add(new TapGestureRecognizer
                    {
                        Command = new Command(() =>
                        {
                            requestDetailsLayout.IsVisible = !requestDetailsLayout.IsVisible;
                            // Rotate the arrow icon up and down
                            arrowIcon.Rotation = isArrowRotated ? 0 : 180;
                            isArrowRotated = !isArrowRotated;
                        })
                    });

                    var requestNumber = new Label
                    {
                        Text = req.Number.ToString(),
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.Center
                    };

                    numberCheckboxArrowLayout.Children.Add(requestNumber);

                    checkboxArrowLayout.Children.Add(customCheckbox);
                    checkboxArrowLayout.Children.Add(arrowIcon);

                    numberCheckboxArrowLayout.Children.Add(checkboxArrowLayout);

                    var newName = new Label()
                    {
                        Text= "Request"
                    };
                    var nameLabel = new Label()
                    {
                        Text = req.Name
                    };

                    var newUnlock = new Label()
                    {
                        Text = "How to Unlock"
                    };
                    var unlockLabel = new Label()
                    {
                        Text = req.HowToUnlock
                    };

                    var newExpires = new Label()
                    {
                        Text = "Expires"
                    };
                    var expiresLabel = new Label()
                    {
                        Text = req.ExpiresDate
                    };

                    var newSolution = new Label()
                    {
                        Text = "Solution"
                    };
                    var solutionLabel = new Label()
                    {
                        Text = req.Solution
                    };

                    var newReward = new Label()
                    {
                        Text = "Reward"
                    };
                    var rewardLabel = new Label()
                    {
                        Text = req.Reward
                    };

                    requestDetailsLayout.Children.Add(newName);
                    requestDetailsLayout.Children.Add(nameLabel);
                    requestDetailsLayout.Children.Add(newUnlock);
                    requestDetailsLayout.Children.Add(unlockLabel);
                    requestDetailsLayout.Children.Add(newExpires);
                    requestDetailsLayout.Children.Add(expiresLabel);
                    requestDetailsLayout.Children.Add(newSolution);
                    requestDetailsLayout.Children.Add(solutionLabel);
                    requestDetailsLayout.Children.Add(newReward);
                    requestDetailsLayout.Children.Add(rewardLabel);

                    requestLayout.Children.Add(numberCheckboxArrowLayout);
                    requestLayout.Children.Add(requestDetailsLayout);

                    RequestsContainer.Children.Add(requestLayout);
                }
            }
        }


        private void RequestArrowTapped(object sender, EventArgs e)
        {
            var arrowImage = (Image)sender;
            var request = arrowImage.BindingContext as Request;
            if (request != null)
            {
                request.AreDetailsVisible = !request.AreDetailsVisible;
                arrowImage.Rotation = request.AreDetailsVisible ? 180 : 0;
            }
        }

    }
}
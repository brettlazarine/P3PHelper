using System;
using Xamarin.Forms;

namespace P3PHelper.Controls
{
    public class CustomCheckBox : CheckBox
    {
        public static readonly BindableProperty IsCompletedProperty = BindableProperty.Create(
            nameof(IsCompleted),
            typeof(bool),
            typeof(CustomCheckBox),
            propertyChanged: OnIsCompletedChanged);

        public bool IsCompleted
        {
            get { return (bool)GetValue(IsCompletedProperty); }
            set { SetValue(IsCompletedProperty, value); }
        }

        private static void OnIsCompletedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var customCheckBox = (CustomCheckBox)bindable;
            var isCompleted = (bool)newValue;

            // Update the custom CheckBox state based on the IsCompleted property
            customCheckBox.IsChecked = isCompleted;
        }
    }
}

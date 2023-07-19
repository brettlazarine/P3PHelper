using System;
using Xamarin.Forms;

namespace P3PHelper.Controls
{
    public class CustomCheckBox : CheckBox
    {
        // Binds to IsCompleted property, used in multiple classes 
        public static readonly BindableProperty IsCompletedProperty = BindableProperty.Create(
            nameof(IsCompleted),
            typeof(bool),
            typeof(CustomCheckBox),
            propertyChanged: OnIsCompletedChanged);

        // Get and Set value for IsCompleted property
        public bool IsCompleted
        {
            get { return (bool)GetValue(IsCompletedProperty); }
            set { SetValue(IsCompletedProperty, value); }
        }
        // Update state of CustomCheckBox
        private static void OnIsCompletedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var customCheckBox = (CustomCheckBox)bindable;
            var isCompleted = (bool)newValue;
            customCheckBox.IsChecked = isCompleted;
        }
    }
}

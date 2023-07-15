using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace P3PHelper.Controls
{
    public class CustomCheckBox : CheckBox
    {
        public static readonly BindableProperty GenderProperty = BindableProperty.Create(
            nameof(Gender),
            typeof(string),
            typeof(CustomCheckBox),
            propertyChanged: OnGenderChanged);

        public string Gender
        {
            get { return (string)GetValue(GenderProperty); }
            set { SetValue(GenderProperty, value); }
        }

        private static void OnGenderChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var customCheckBox = (CustomCheckBox)bindable;
            var gender = (string)newValue;

            // Set the color based on gender
            if (gender == "Male")
                customCheckBox.Color = Color.Blue;
            else if (gender == "Female")
                customCheckBox.Color = Color.Pink;
            else
                customCheckBox.Color = Color.Default;
        }
    }
}

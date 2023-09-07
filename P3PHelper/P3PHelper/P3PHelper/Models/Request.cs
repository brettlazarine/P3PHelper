using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Essentials;

namespace P3PHelper.Models
{
    public class Request : INotifyPropertyChanged
    {
        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                if (_isCompleted != value)
                {
                    _isCompleted = value;
                    OnPropertyChanged(nameof(IsCompleted));

                    // Update Preferences here
                    //Preferences.Set("Request_IsCompleted_" + Number, value);
                }
            }
        }
        private ObservableCollection<Request> _requests { get; set; }
        [JsonIgnore]
        public ObservableCollection<Request> Requests
        {
            get { return _requests; }
            set
            {
                if (_requests != value)
                {
                    _requests = value;
                    OnPropertyChanged(nameof(Requests));
                }
            }
        }
        [PrimaryKey]
        public int Number { get; set; }
        public string Name { get; set; }
        public string HowToUnlock { get; set; }
        public string ExpiresDate { get; set; }
        public string Solution { get; set; }
        public string Reward { get; set; }
        private bool _areDetailsVisible;
        public bool AreDetailsVisible
        {
            get { return _areDetailsVisible; }
            set
            {
                if (_areDetailsVisible != value)
                {
                    _areDetailsVisible = value;
                    OnPropertyChanged(nameof(AreDetailsVisible));
                }
            }
        }

        public Request()
        {
            // Constructor defaults to FALSE so that users can update their progress with checkboxes in Request view
            IsCompleted = false;

            Requests = new ObservableCollection<Request>();
            // Constructor adds new Request to ObservableCollection<Request> Requests for iteration in ViewModel
            Requests.Add(this);

            AreDetailsVisible = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

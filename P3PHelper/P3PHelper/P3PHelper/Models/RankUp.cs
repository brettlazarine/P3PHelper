using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace P3PHelper.Models
{
    public class RankUp : INotifyPropertyChanged
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
                }
            }
        }
        public int RankNumber { get; set; }
        public List<(string Question, string Answer)> Questions { get; set; }

        public RankUp()
        {
            // Constructor defaults to FALSE so that users can update their progress with checkboxes in SLink views
            IsCompleted = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


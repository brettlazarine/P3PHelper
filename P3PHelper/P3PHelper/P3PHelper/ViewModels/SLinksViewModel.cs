using P3PHelper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P3PHelper.ViewModels
{
    public class SLinksViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SLink> _sLinks;
        public ObservableCollection<SLink> SLinks
        {
            get { return _sLinks; }
            set
            {
                _sLinks = value;
                OnPropertyChanged(nameof(SLinks));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SLink CreateAeonInstance()
        #region
        {
            return new SLink()
            {
                Arcana = "Aeon",
                //Female
                FemaleName = "Aigis",
                FemaleUnlockDate = "1/8",
                FemaleHowToUnlock = "Talk to her in the classroom on 1/8.",
                FemaleAvailability = "Can be found in the classroom every day except Sunday.",
                FemaleRankUps = new List<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("What about you? Do you… like this town?" , "I like it.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("……" , "That’s not true.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("It seems the old lady will suffer greatly if they remain separated for much longer…" , "Sure.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("It seems that ‘living’ is something that can’t be done alone…" , "You may be right.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Did I do something wrong?" , "He wanted to date you.  +3   OR   No you didn’t.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("I was just curious…" , "Not yet…  +3   OR   Sometimes.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("January 31st…" , "Yeah, huh.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    }
                },
                //Male
                MaleName = "Aigis",
                MaleUnlockDate = "1/8",
                MaleHowToUnlock = "Talk to her in the classroom on 1/8.",
                MaleAvailability = "Can be found in the classroom every day except Sunday.",
                MaleRankUps = new List<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("What about you? Do you… like this town?" , "I like it.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("……" , "That’s not true.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("It seems the old lady will suffer greatly if they remain separated for much longer…" , "All right. +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("It seems that ‘living’ is something that can’t be done alone…" , "You may be right.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Did I do something wrong?" , "No, you didn't.  +3   OR   He saw me as a boyfriend.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("I was just curious…" , "I’m doing it now.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("January 31st…" , "You’re right.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    }
                }
            };
        }
        #endregion  
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

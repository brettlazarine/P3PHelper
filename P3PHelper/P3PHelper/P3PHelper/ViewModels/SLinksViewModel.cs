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
        {
            return new SLink()
            {
                Arcana = "Aeon",
                // Male
                MaleName = "Aigis",
                MaleUnlockDate = "1/8",
                MaleHowToUnlock = "Talk to her in the classroom on 1/8.",
                MaleAvailability = "Can be found in the classroom every day except Sunday.",
                MaleRankUps = new ObservableCollection<RankUp>
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
                },
                // Female
                FemaleName = "Aigis",
                FemaleUnlockDate = "1/8",
                FemaleHowToUnlock = "Talk to her in the classroom on 1/8.",
                FemaleAvailability = "Can be found in the classroom every day except Sunday.",
                FemaleRankUps = new ObservableCollection<RankUp>
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
                }               
            };
        }

        public SLink CreateChariotInstance()
        {
            return new SLink()
            {
                Arcana = "Chariot",
                // Male
                MaleName = "Kazushi Miyamoto",
                MaleUnlockDate = "4/24",
                MaleHowToUnlock = "Join a sports club.",
                MaleAvailability = "Can be found in the classroom on Monday, Wednesday, Thursday, and Friday.",
                MaleRankUps = new ObservableCollection<RankUp>
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
                            ("M-my side is killing me…" ,
                            "Toughen up.  +2 \n After this conversation, talk to Yuko and ask to walk home with her.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("My asthma’s just acting up…" , "Are you sure you’re okay?  +2"),
                            ("Even if I put medicine on it, or massage it, the pain won’t go away." , "Will it heal? \n" +
                            "After this conversation, talk to Yuko and ask to walk home with her. Agree to go where she wants.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("She made the appointment without telling me, so there was nothing I could do!" , "That sucks.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Wh-what’s up…? You’re probably wondering where I’ve been…" , "The hospital again?  +2"),
                            ("Dammit! I can’t…" , "Let him use your shoulder.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Well, I just want to win…" , "Suck it up.  +2"),
                            ("I promised to be the number one athlete in Japan." , "Is it that important?  +2"),
                            ("So, I have to win this meet to make it to nationals." , "What about your knee?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("I’m not accusing you of telling him, but damn! What should I do? I think he knows…" ,
                            "How’s your knee?  +2"),
                            ("Otherwise, I won’t be able to keep my promise to my nephew!" , "You need to toughen up.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("You must know something…" , "Look away.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I’m sure you love lugging all this dead weight around, right?" , "I’m fine.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("I’ve made up my mind. I’m going to have surgery to fix my knee…" , "What about the big meet?  +3")
                        }
                    }
                },
                // Female
                FemaleName = "Rio Iwasaki",
                FemaleUnlockDate = "4/24",
                FemaleHowToUnlock = "Join a sports club.",
                FemaleAvailability = "Can be found outside the classroom on Monday, Wednesday, and Friday.",
                FemaleRankUps = new ObservableCollection<RankUp>
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
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Sorry, but I want to be left alone right now." , "That ain’t happening.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Oh, sorry… I ended up loafing around." , "You seem to get along with him.  + 3"),
                            ("All that stuff about having never been in a relationship… That’s none of their business." ,
                            "Don’t let it get to you!  +3"),
                            ("… do you have… someone you like?" , "Nope.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("..., you know who it is, right? Tell us!" , "I have no idea.  +3"),
                            ("Why don’t we practice?" , "Are you sure you’re okay?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("I’m gonna… go tell him." , "That’s the spirit!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("You’ve really got an eye for details. Seriously, you’re a much better leader than I am." , "Thanks.  +3")
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

        public SLink CreateDeathInstance()
        {
            return new SLink()
            {
                Arcana = "Death",
                MaleRequiresPersona = false,
                // Male
                MaleName = "Pharos",
                MaleUnlockDate = "6/12",
                MaleHowToUnlock = "Story related.",
                MaleAvailability = "Story related.",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "6/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "7/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "8/7")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "9/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "10/6")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/4")
                        }
                    }
                },
                // Female
                FemaleRequiresPersona = false,
                FemaleName = "Pharos",
                FemaleUnlockDate = "6/12",
                FemaleHowToUnlock = "Story related.",
                FemaleAvailability = "Story related.",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "6/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "7/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "8/7")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "9/12")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "10/6")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/4")
                        }
                    }
                }
            };
        }

        public SLink CreateDevilInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateEmperorInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateEmpressInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateFoolInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateFortuneInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateHangedManInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateHermitInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateHierophantInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateJudgementInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateJusticeInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateLoversInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateMagicianInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateMoonInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreatePriestessInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateStarInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateStrengthInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateSunInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateTemperanceInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public SLink CreateTowerInstance()
        {
            return new SLink()
            {
                Arcana = "",
                // Male
                MaleName = "",
                MaleUnlockDate = "",
                MaleHowToUnlock = "",
                MaleAvailability = "",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    }
                },
                // Female
                FemaleName = "",
                FemaleUnlockDate = "",
                FemaleHowToUnlock = "",
                FemaleAvailability = "",
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("" , "")
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

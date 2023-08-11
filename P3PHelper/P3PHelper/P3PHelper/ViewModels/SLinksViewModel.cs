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
                            ("Did I do something wrong?" , "No, you didn't.  +3\nOR\nHe saw me as a boyfriend.  +3")
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
                            ("Did I do something wrong?" , "He wanted to date you.  +3\nOR\nNo you didn’t.  +3")
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
                            ("I was just curious…" , "Not yet…  +3\nOR\nSometimes.  +3")
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
                Arcana = "Devil",
                // Male
                MaleName = "President Tanaka",
                MaleUnlockDate = "6/23",
                MaleHowToUnlock = "Must have Charm at level 4, and Hermit Arcana at rank 4. On 6/16, visit Tanaka and give him" +
                    " 20,000 yen. Pay him another visit, and pay him 10,000 yen. Finally, visit him again on 6/23 and pay him another " +
                    "10,000 yen.",
                MaleAvailability = "Can be found at Paulownia Mall at night on Tuesday, Thursday, and Saturday.",
                MaleRequiresPersona = false,
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
                            ("‘Placebo!’ The stress is on the middle syllable." , "Placebo.  +3"),
                            ("These are part of our unique line of products." , "Wow!  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("How about you? Are you interested in stock trading?" , "Maybe a little.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Have you ever wondered what it would be like to be able to see through people’s " +
                            "bathing suits at the beach?" , "I sure have!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Oh dear me… I just can’t concentrate. I get so worked up when I picture his face!" , 
                            "Who’re you talking about?  +2"),
                            ("It makes me sick just thinking about it… Uh…" , "Is it always about money?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Recently, my alumni association organized a class reunion." , "Sounds fun.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Do you notice anything different about me?" , "Sort of…  +3"),
                            ("Which one do you think the supermarket would stock?" , "The organic one.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("He said, ‘Thank you.’" , "Oh, really?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("No matter how attractive she was, I was repulsed by her dedication to charity work." ,
                            "Are you going to donate?  +3")
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
                FemaleName = "President Tanaka",
                FemaleUnlockDate = "6/23",
                FemaleHowToUnlock = "Must have Charm at level 2, and Hermit Arcana at rank 2. On 6/16, visit Tanaka and give him" +
                    " 20,000 yen. Pay him another visit, and pay him 10,000 yen. Finally, visit him again on 6/23 " +
                    "and pay him another 10,000 yen.",
                FemaleAvailability = "Can be found at Paulownia Mall at night on Tuesday, Thursday, and Saturday.",
                FemaleRequiresPersona = false, 
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Any response.", "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("‘Placebo!’ The stress is on the middle syllable." , "Placebo!  +3"),
                            ("These are part of our unique line of products." , "Wow!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("How about you? Are you interested in stock trading?" , "I am.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Have you ever wondered what it would be like to be able to see through people’s " +
                            "bathing suits at the beach?" ,
                            "I have.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Oh dear me… I just can’t concentrate. I get so worked up when I picture his face!" , "Who?  +3"),
                            ("It makes me sick just thinking about it… Uh…" , "It’s all about money…  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Recently, my alumni association organized a class reunion." , "Sounds like fun!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Do you notice anything different about me?" , "Kind of…  +3"), 
                            ("Which one do you think the supermarket would stock?" , "The organic one.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("He said, ‘Thank you.’" , "Good for you.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("No matter how attractive she was, I was repulsed by her dedication to charity work." ,
                            "Are you going to donate?  +3")
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
                Arcana = "Emperor",
                // Male
                MaleName = "Hidetoshi Odagiri",
                MaleUnlockDate = "4/27",
                MaleHowToUnlock = "Starting on 4/27, talk to Ms. Toriumi in the Faculty Office about joining the Student Council.",
                MaleAvailability = "Can be found in the Student Council Room on Monday, Wednesday, and Friday.",
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
                            ("Some students feel the school uniform should be abolished, and they’re recruiting supporters…" ,
                            "It’s a waste of time.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("He is staring at Hidetoshi." , "Stop fighting.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("You look like you want to say something…" , "Good work.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("...-kun, were you there the whole time?" , "They can be pretty cruel.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("As you can see, the meeting’s over, so you can leave if you want…" , "But I just got here…  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("…about the smoker’s punishment, that is." , "He should suffer.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Hidetoshi looks uncomfortable." , "It wasn’t me.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I rambled on about rules and fairness, but all I really proved was that I was desperate for power…" ,
                            "Don’t blame yourself.  +3")
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
                FemaleName = "Hidetoshi Odagiri",
                FemaleUnlockDate = "4/27",
                FemaleHowToUnlock = "Starting on 4/27, talk to Ms. Toriumi in the Faculty Office about joining the Student Council.",
                FemaleAvailability = "Can be found in the Student Council Room on Monday, Wednesday, and Friday.",
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
                            ("Some students feel the school uniform should be abolished, and they’re recruiting supporters…" ,
                            "How pointless.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("The student council member is glaring at Hidetoshi." , "You shouldn’t fight.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("You look like you want to say something…" , "Working hard, huh?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Were you there the whole time?" , "They were all mean.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("As you can see, the meeting’s over, so you can leave if you want…" , "I’ll help out, too!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("…about the smoker’s punishment, that is." , "A strict punishment.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Hidetoshi looks uncomfortable." , "I’m not the culprit.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I rambled on about rules and fairness, but all I really proved was that I was desperate for power…" ,
                            "Don’t blame yourself.  +3")
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
                Arcana = "Empress",
                // Male
                MaleName = "Mitsuru Kirijo",
                MaleUnlockDate = "11/21",
                MaleHowToUnlock = "Must have Academics at level 6, then talk to her in front of Faculty Office. When she asks if you " +
                "have any spare time, say 'Sure'.",
                MaleAvailability = "Can be found in front of the Faculty Office on Tuesday, Thursday, and Saturday.",
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
                            ("Mitsuru seems nervous." , "Is this your first time?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuru seems dejected." , "Ask her to treat you.  +2"),
                            ("Perhaps he’s just maturing…" , "Does that make you happy?  +3"),
                            ("I can’t explain why, though…" , "Maybe you’re in love.  +2"),
                            ("Sorry for subjecting you to my incoherent ramblings… Please forget what I just said." , 
                            "Agree to forget about it.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Soon, we’ll be looking back nostalgically on these times…" , "Did something happen?  +2"),
                            ("What are your thoughts on marriage?" , "It’s the result of love.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I find it interesting that so much thought is put into the design and construction of a movie theater." ,
                            "I’m glad you enjoyed it.  +3"),
                            ("She’s also more suited to ride a motorcycle." , "A motorcycle?  +3"), 
                            ("Mitsuru seems happy." , "Let’s go for a ride.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuru is looking at the bookshelf." , "Can I get a book for you?  +2"),
                            ("It’s the best solution for everyone involved." , "That’s news to me!  +2"),
                            ("I won’t run from my destiny." , "You have to reconsider.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Is that being selfish?" , "Let’s do it!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuru is trembling with anger." , "Say something to the guy.  +3"), 
                            ("Mitsuru is leaving…" , "Stop her.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I am so sorry about what happened the other day." , "That makes me happy.  +3")
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
                FemaleName = "Mitsuru Kirijo",
                FemaleUnlockDate = "11/21",
                FemaleHowToUnlock = "Must have Academics at level 6, then talk to her in front of Faculty Office. When she asks if you " +
                    "have any spare time, say 'Sure'.",
                FemaleAvailability = "Can be found in front of the Faculty Office on Tuesday, Thursday, and Saturday.",
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
                            ("Mitsuru seems nervous." , "Is this your first time?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuru seems dejected." , "Anyways, let’s eat."),
                            ("Perhaps he’s just maturing…" , "Does that make you happy?  +3"),
                            ("I can’t explain why, though…" , "...Love?  +2"),
                            ("Sorry for subjecting you to my incoherent ramblings… Please forget what I just said." , 
                            "Okay, I will.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Soon, we’ll be looking back nostalgically on these times…" , "You seem troubled…  +3"),
                            ("What are your thoughts on marriage?" , "To be with your true love.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("You can have boredom written all over your face without having to consider the feelings of others." ,
                            "Was it boring?  +3"), 
                            ("You may be more suited to ride a motorcycle than me." , "Motorcycle?  +3"),
                            ("Mitsuru seems happy." , "Can I ride with you someday?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuru is looking at the bookshelf." , "Not feeling well?  +3"),
                            ("It’s the best solution for everyone involved." , "It’s the first I’ve heard…  +3"),
                            ("I won’t run from my destiny." , "You should reconsider!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("When you’re with me… what do you think?" , "I enjoy myself.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuru is trembling with anger." , "Say something to the guy.  +3"),
                            ("Mitsuru is leaving…" , "Stop her.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I’m so sorry about what happened the other day. It must have upset you." , "You were cool.  +3")
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
                Arcana = "Fool",
                // Male
                MaleName = "S.E.E.S.",
                MaleUnlockDate = "4/20",
                MaleHowToUnlock = "Story related.",
                MaleAvailability = "Story related.",
                MaleRequiresPersona = false,
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "4/20")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "4/21")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "5/9")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "7/7")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "7/22")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/4")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/28")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "12/31")
                        }
                    }
                },
                // Female
                FemaleName = "S.E.E.S.",
                FemaleUnlockDate = "4/20",
                FemaleHowToUnlock = "Story related.",
                FemaleAvailability = "Story related.",
                FemaleRequiresPersona = false, 
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "4/20")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "4/21")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "5/9")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "7/7")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "7/22")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/4")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "11/28")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "12/31")
                        }
                    }
                }
            };
        }

        public SLink CreateFortuneInstance()
        {
            return new SLink()
            {
                Arcana = "Fortune",
                // Male
                MaleName = "Keisuke Hiraga",
                MaleUnlockDate = "6/17",
                MaleHowToUnlock = "Join one of the culture clubs.",
                MaleAvailability = "Can be found outside the entrance to the culture club you chose on Tuesday, Wednesday, and Thursday.",
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
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("What will you say to him?" , "Great job!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Ugh, I can’t take it anymore! I have my own dreams, you know!" , "Complaining won’t help.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Th-Then, that means…." , "You should tell your dad.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I don’t know what I should do. *sigh* I’m so confused…" , "Do whatever you want.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("It’s like he thinks he understands me now…" , "Are you gonna be a doctor?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("How is your memory? Can you tell me your name?" , "Yeah, I’m fine.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Will you try to stop Keisuke from going?" , "Try to stop him.  +3")
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
                FemaleName = "Ryoji Mochizuki",
                FemaleUnlockDate = "11/9",
                FemaleHowToUnlock = "Story related.",
                FemaleAvailability = "You MUST agree to each of his requests to spend time together. REFUSING WILL END THE SOCIAL LINK!",
                FemaleRequiresPersona = false,
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
                            ("On 11/12\nAny response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("On 11/13, you MUST hang out with him.\nAny response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("On 11/15\nAny response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("On 11/19\n" +
                            "You can't find this in Iwatodai. *chuckle* It makes me kind of happy." , 
                            "What makes you happy?  +3"),
                            ("The light reflects off the river in a different way than it shines off of the ocean..." , 
                            "Is it because it's flowing?  +3"),
                            ("I'd like to spend some more time with you..." , "Okay.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("On 11/22\nAny response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("On 11/27\nAny response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("On 11/29\nI wonder if we'll get in trouble if someone finds us." , "We'll just have to not be seen.  +3"),
                            ("I'm..." , "You're Ryoji."),
                            ("You feel that you need to respond carefully to this." , 
                            "Romantic: Okay.  +3\nPlatonic: As a friend, then...  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("On 12/1, you MUST hang out with him.\nAny response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("On 12/31\nThis response results in the True or Bad ending. The True ending will max out the Social Link." , 
                            "True Ending: Let Ryoji live\n Bad Ending: Kill Ryoji")
                        }
                    }
                }
            };
        }

        public SLink CreateHangedManInstance()
        {
            return new SLink()
            {
                Arcana = "Hanged Man",
                // Male
                MaleName = "Maiko Oohashi",
                MaleUnlockDate = "5/6",
                MaleHowToUnlock = "Buy a Mad Bull from the Dormitory's 2nd floor Vending Machine, and a Weird Takoyaki from " +
                "Octopia at the Iwatodai Strip Mall. Go to Naganaki Shrine and give them to the little girl at the playground. Speak to " +
                "her again another day after giving her the Mad Bull and Weird Takoyaki to get the first rank.",
                MaleAvailability = "Can be found at Naganaki Shrine by the playground every day except Sunday. She must also " +
                "be rescued from Tartarus between 10/21 and 11/3.",
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
                            ("Can we go to Wild-duck Burger?" , "Sure, let’s go.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Oh! Do you think he’ll come home for my birthday?" , "Don’t worry, he’ll be there.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("They remembered!" , "I’m happy for you.  +3\nOR\nNobody could forget you.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I don’t know what to do…" , "That’s terrible.  +3"),
                            ("I bet they wouldn’t care if I wasn’t even here at all!" , "That isn’t true.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I made up my mind! I have to run away from home!" , "Calm down.  +2"),
                            ("What about my health insurance card?" , "That should be enough.  +3")
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
                            ("What do you feel like eating?" , "Hamburgers.  +2"),
                            ("I was sad, but I listened to what they said. Did I do good?" , "Yeah, you did good.  +3"),
                            ("You decide for me, okay?" , "Choose your dad.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("We’ll still be friends though, right?" , "We’re friends forever.  +3")
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
                FemaleName = "Maiko Oohashi",
                FemaleUnlockDate = "5/6",
                FemaleHowToUnlock = "Buy a Mad Bull from the Dormitory's 2nd floor Vending Machine, and a Weird Takoyaki from " +
                "Octopia at the Iwatodai Strip Mall. Go to Naganaki Shrine and give them to the little girl at the playground. Speak to " +
                "her again another day after giving her the Mad Bull and Weird Takoyaki to get the first rank.",
                FemaleAvailability = "Can be found at Naganaki Shrine by the playground every day except Sunday. She must also " +
                "be rescued from Tartarus between 10/21 and 11/3.",
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
                            ("Can we go to Wild-duck Burger?" , "Sure, let’s go.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Oh! Do you think he’ll come home for my birthday?" , "Don’t worry, he’ll be there.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("They remembered!" , "Good for you!  +3\nOR\nOf course, they love you!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I don’t know what to do…" , "That’s mean!  +3"),
                            ("I bet they wouldn’t care if I wasn’t even here at all!" , "That isn’t true.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I made up my mind! I have to run away from home!" , "Calm down.  +2"),
                            ("What about my health insurance card?" , "That’s good enough.  +3")
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
                            ("What do you feel like eating?" , "How about hamburgers?  +3"),
                            ("I was sad, but I listened to what they said. Did I do good?" , "Good girl!  +3"),
                            ("You decide for me, okay?" , "Your dad.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("We’ll still be friends though, right?" , "We’re friends forever.  +3\nOR\nWe’re sisters forever.  +3")
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
                Arcana = "Hermit",
                // Male
                MaleName = "Maya",
                MaleUnlockDate = "4/29",
                MaleHowToUnlock = "Talk to Junepi on the evening of 4/28 at the Dormitory to get a copy of " +
                "the Innocent Sin Online MMORPG.",
                MaleAvailability = "Can be interacted with on the computer on the desk in your room on Sunday.",
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
                            ("u remember me rite? =/" , "Of course.  +3"),
                            ("hmmm… what kinda people r we, playing inside on such a beautiful day?" , "Sunshine is overrated.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("so ummmmm…… i’m drunk! xD" , "Oh really?! o_O"),
                            ("but lately i cant get motivated to get ne work done @ work. =/" , "So you don’t like your job?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("…ugh. its like all she cares about is marrying me to some dude >=/" , "Why don’t we get married?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Mr. E is such a stupid eh so bee!! t(-_-t)" , "Don’t you mean S.O.B.?  +3"),
                            ("…oh noes! u can’t figure out what my job is can u? O_o?" , "Are you a teacher?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("actually, i only went cuz i was so pissed at that bastard! >=/" , "Which bastard?!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("…do men only want younger women? be honest w/ me =3" , "Guys like younger chicks.  +3"),
                            ("she even stuffs her bra!! lol" , "She um… what?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("oh noes… now i’m starting to get sweaty =/" , "Hurry up and tell me.  +3"),
                            ("goin for younger guys is kinda new for me >_>" , "What is he like?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("it said their canceling innocent sin. …think its for real?!" , "No way!  +3"),
                            ("maya’s not goin quietly! >=/ i’ll beat them to the punch!" , "What are you planning?  +3")
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
                FemaleName = "Saori Hasegawa",
                FemaleUnlockDate = "5/8",
                FemaleHowToUnlock = "Join either the Library or Health committee.",
                FemaleAvailability = "Can be found outside either the Library (Library committee)" +
                    " or the Nurse's Office (Health committee) on Tuesday and Thursday.",
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
                            ("We should put them on the shelves. Can you help me out?" , "Of course!  +3"),
                            ("I see you sometimes in the hall, and you always look like you’re having fun." ,
                            "You should’ve come talk to me.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Whew. Today was pretty rough, don’t you think?" , "Let’s stay here a little longer.  +3"),
                            ("Well, there’s no point complaining about what I don’t have." , "Won’t you confront her?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("If he really wants to go out with me, then…" , "Aren’t you being a doormat?  +3"),
                            ("Do you think it’s wrong to think that way?" , "I can understand that.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I’m sorry you had to see that…" , "I don’t mind at all.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I wonder… Is it my fault that nobody’s come in today?" , "What did you do?  +3"),
                            ("If they see you with me, they might start new rumors…" , "Let them talk.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("If you stay near me, you’re going to lose any reputation you had." , "Don’t worry about it.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Saori hangs her head low…" , "Don’t let it get to you.  +3"),
                            ("…I don’t want to get you involved." , "I don’t mind that at all.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("……" , "I’m going to punch them.  +3"),
                            ("I don’t care how other people see me… But I want you to know that." , "I believe you.  +3")
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
                Arcana = "Hierophant",
                // Male
                MaleName = "Bunkichi and Mitsuko",
                MaleUnlockDate = "4/25",
                MaleHowToUnlock = "Visit Bookworms at Iwatodai Strip Mall and talk to Bunkichi and Mitsuko until they have mentioned " +
                    "the Persimmon tree. Go to Gekkoukan High and find the Persimmon tree by heading out of the main building " +
                    "toward the sports clubs. Find the tree on the left, and interact with it to find a Persimmon Leaf. Return to " +
                    "Bookworms and deliver the leaf to Bunkichi and Mitsuko.",
                MaleAvailability = "Can be found in Bookworms at Iwatodai Strip Mall every day except Monday. Must be rescued " +
                    "from Tartarus between 9/12 and 10/4.",
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
                            ("What was your name again?" , "Tell him.  +2"),
                            ("Someone gave them to me, but I have more than enough. Go ahead, take one." , "Thanks!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("But I can’t seem to find it." , "Looking for something?  +2"),
                            ("I’m looking for my glasses… No, not my glasses - my wallet. I can’t seem to find it." ,
                            "I’ll help you look.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("My wife just left for Gekkoukan." , "I should go there too.  +3"),
                            ("Do you know anything about it, ...?" , "Now, you have me worried.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I’m sorry for troubling you about the persimmon tree…" , "I’ll ‘root’ out the truth!  +2"),
                            ("Why now…? Why do they want to cut it down now?" , "Don’t worry.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("But, if that tree is removed, I feel like the memory of my son will vanish with it…" ,
                            "Please stop quarreling.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuko is crying." , "Ask why she’s crying.  +2"),
                            ("They say the tree is a memorial to their former teacher… They don’t want it to be cut down." ,
                            "That’s great.  +2"),
                            ("..., were you the one who called them all?" , "What are you talking about?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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
                FemaleName = "Bunkichi and Mitsuko",
                FemaleUnlockDate = "4/25",
                FemaleHowToUnlock = "Visit Bookworms at Iwatodai Strip Mall and talk to Bunkichi and Mitsuko until they have mentioned " +
                    "the Persimmon tree. Go to Gekkoukan High and find the Persimmon tree by heading out of the main building " +
                    "toward the sports clubs. Find the tree on the left, and interact with it to find a Persimmon Leaf. Return to " +
                    "Bookworms and deliver the leaf to Bunkichi and Mitsuko.",
                FemaleAvailability = "Can be found in Bookworms at Iwatodai Strip Mall every day except Monday. Must be rescued " +
                    "from Tartarus between 9/12 and 10/4.",
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
                            ("What was your name again?" , "I’m from Gekkoukan.  +3"),
                            ("Someone gave them to me, but I have more than enough. Go ahead, take one." , "Thank you.  +3"),
                            ("He should be here helping customers. I’m sorry, ...-chan." , "It’s okay.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("But I can’t seem to find it." , "Looking for something?  +3"),
                            ("I’m looking for my glasses… No, not my glasses - my wallet. I can’t seem to find it." ,
                            "I’ll help look for it.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("My wife just left for Gekkoukan." , "Maybe I’ll run after her.  +3"),
                            ("Do you know anything about it, ...?" , "That makes me worry...  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I’m sorry for troubling you about the persimmon tree…" , "It’s what you ‘beleave’.  +3"),
                            ("Why now…? Why do they want to cut it down now?" , "Don’t worry.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuko looks upset…" , "Please stop fighting.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Mitsuko is crying." , "What’s wrong?  +3"),
                            ("They say the tree is a memorial to their former teacher… They don’t want it to be cut down." ,
                            "Thank goodness...  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("I have to tell my son the good news!" , "Let’s go!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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
                Arcana = "Judgement",
                // Male
                MaleName = "Nyx Annihilation Team",
                MaleUnlockDate = "12/31",
                MaleHowToUnlock = "Let Ryoji live.",
                MaleAvailability = "Story related.",
                MaleRequiresPersona = false,
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "12/31")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 215 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 220 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 224 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 228 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 236 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 240 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 244 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 252 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 254 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    }
                },
                // Female
                FemaleName = "Nyx Annihilation Team",
                FemaleUnlockDate = "12/31",
                FemaleHowToUnlock = "Let Ryoji live.",
                FemaleAvailability = "Story related.",
                FemaleRequiresPersona = false,
                FemaleRankUps = new ObservableCollection<RankUp>
                {

                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Story related." , "12/31")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 215 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 220 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 224 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 228 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 236 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 240 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 244 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 252 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Reach floor 254 of Tartarus." , "Starting 1/1, must complete before 1/31.")
                        }
                    }
                }
            };
        }

        public SLink CreateJusticeInstance()
        {
            return new SLink()
            {
                Arcana = "Justice",
                // Male
                MaleName = "Chihiro Fushimi",
                MaleUnlockDate = "5/26",
                MaleHowToUnlock = "Unlock Emperor rank 1, then talk to her 4 times.",
                MaleAvailability = "Can be found in the 2nd Floor Hallway on Tuesday, Thursday, and Saturday.",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("First interaction." , "I wanted to talk..."),
                            ("Second interaction." , "I'm male."),
                            ("Third interaction." , "Hello.\nLet's go out."),
                            ("Fourth interaction." , "Let's walk home together.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Sorry to subject you to this." , "Don’t worry about it.  +3"),
                            ("Do you read much?" , "I read the classics.  +2\nOR\nI read manga.  +2"),
                            ("Is it boring to hang around with a nerd like me?" , "Not really.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Where do they think they are?!" , "How rude.  +2"),
                            ("Let’s discuss this in our next meeting!" , "I agree.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Why am I still shaking?" , "Speak to her calmly.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("What should I do…?" , "So, how was it?  +3"),
                            ("I-I have dreams about you every single night!" , "It’s just a coincidence.  +2"),
                            ("Sorry…" , "Don’t be hard on yourself.  +2"),
                            ("What will you do?" , "Hold her hand.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Wh-what should I do…?" , "Is it good?  +3"),
                            ("Until recently…" , "What do you mean?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("...-san…" , "You’re not to blame.  +3"),
                            ("I couldn’t stand up to them… But… I… didn’t take anything!" , "We have to do something…  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("I have no one else to turn to in school…" , "Talk to the teacher.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Don’t tell me the President thinks I stole the money too?!" , "Don’t worry. She’ll help us.  +2"),
                            ("You made eye contact with Chihiro." , "Wait and see what happens.  +2"),
                            ("Hahaha…" , "What’s wrong?  +2")
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
                FemaleName = "Ken Amada",
                FemaleUnlockDate = "9/1",
                FemaleHowToUnlock = "Must have level 6 Courage.",
                FemaleAvailability = "Can be found in the Dormitory Lounge at night on Tuesday and Thursday.",
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
                            ("He carefully pushes the bell peppers aside to reach the meat…" ,
                            "You shouldn’t be a picky eater.  +3"),
                            ("Should you try changing the subject?" , "What’s popular at your school?  +3"),
                            ("Do you watch any TV shows?" , "I like action shows too.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("If the rice was cooked around noon, I guess there’s nothing to be done about it…" ,
                            "Want to come earlier next time?  +3"),
                            ("There’s something that you put in that makes the rice taste better when you cook it." ,
                            "Honey?  +3"),
                            ("And you’re a girl, too…" , "I just can’t stop reading them…  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Is it true that you won’t get big and strong if you don’t eat right?" , "It’s true.  +3"),
                            ("You’d prefer someone like Akihiko-san too, right?" , "Nope, not at all.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("It’s not good…" , "Actually, I want to hear more.  +3"),
                            ("I threw all of them away." , "I’ll buy you a different series.  +3"),
                            ("I hate that you feel that way." , "You’re okay the way you are.  +3"),
                            ("I was getting worried that yours might taste bad too, if you’re with me…" ,
                            "That’s not true.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("…" , "Did you not write anything?  +3"),
                            ("Ken looks like he’s ready to burst into tears." , "That’s just how I am.  +3"),
                            ("Ken falls silent…" , "I’m with you.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("…" , "Platonic:\nI have one.\nOR\nWho cares about stuff like that!\n" +
                                "Romance:\nA romance option does exist for Ken, but you're on your own for this one.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("You must be honest with him." , "You’re a special friend.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("It all depends on how I become one." , "There’s no rush.  +3")
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
                Arcana = "Lovers",
                // Male
                MaleName = "Yukari Takeba",
                MaleUnlockDate = "7/25",
                MaleHowToUnlock = "Charm must be level 6.",
                MaleAvailability = "Can be found in the Classroom on Monday, Wednesday, Thursday, and Saturday.",
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
                            ("Hey, I think I’m gonna go with gerberas, but which color should I get?" , "Pink’s cute.  +3"),
                            ("Oh, you've never seen my room, have you? Well, what good are you?" ,
                            "That’s messed up.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Sorry." , "Are you all right?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Yukari is trembling. It doesn't seem like she really means what she's saying." , 
                            "Sorry.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Thanks for your help back then. I really appreciate it." , "Anytime.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Maybe we’ll even see a deer or something. Whaddya think?" , "Sounds good.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("How ‘bout you pick one out for me?" , "Alright.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Yukari is quiet…" , ".....   +3")
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
                FemaleName = "Yukari Takeba",
                FemaleUnlockDate = "4/28",
                FemaleHowToUnlock = "No requirements, just talk to her in the classroom.",
                FemaleAvailability = "Can be found in the Classroom on Monday, Wednesday, Thursday, and Saturday.",
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
                            ("Hey, what’s your favorite flower?" ,
                            "Roses, no question.  +3\nOR\nI like gerbera.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Sorry." , "Are you all right?  +3")
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
                            ("D-did it make you mad?!" , "No?  +3"),
                            ("*chuckle* …I wonder why." , "Isn’t it because we’re friends?  +3")
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
                            ("How ‘bout you pick a pair for me?" , "Let’s get a matching set!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I’m thinking about looking for a boyfriend." , "You won’t have a problem with that.  +3")
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
                Arcana = "Magician",
                // Male
                MaleName = "Kenji Tomochika",
                MaleUnlockDate = "4/23",
                MaleHowToUnlock = "Story related.",
                MaleAvailability = "Can be found in the Classroom Tuesday, Thursday, and Friday.",
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
                            ("So, can you, like, go into Yukari-san’s room and stuff?" , "No.  +2\nOR\nThat’s a secret.  +2"),
                            ("When it comes to women, I like them to be older than me. What about you?" ,
                            "I like older women.  +2\nOR\nI like them all.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Dude, I’m so sick of this…" , "What, life?  +2"),
                            ("Well, ..., that settles it. I’m gonna get myself a girlfriend." , "Go for it.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("I’m gonna ask Ms. Kanou out right now!" , "Good luck.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Yeah, good looking people are just attracted to one another. It’s like they’re meant to be together." ,
                            "I agree.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I mean, getting into college is more important than hanging out, right? Don’t you think about the future?" ,
                            "I have 30-year goals.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Sigh. I can’t eat…" , "Ask what’s wrong.  +2"),
                            ("I saw a magazine on Emiri’s coffee table. Guess what it was called…" , "Bride-to-Be Magazine.  +2"),
                            ("Whaddaya think, ...?" , "That’s great. Congrats!  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Hey man… S-sorry I asked you to come here. I, um… Oh, never mind." , "Are you in trouble?  +2"), 
                            ("Emiri is being transferred to a school in Kyushu… What should I do, dude?" ,
                            "You should go with her.  +2\nOR\nYou should talk to her.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("What will you do?" , "Confront Emiri.  +3")
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
                FemaleName = "Junpei Iori",
                FemaleUnlockDate = "4/23",
                FemaleHowToUnlock = "Story related.",
                FemaleAvailability = "Can be found in the classroom on Tuesday, Thursday, and Friday.",
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
                            ("Junpei’s eyes are lit up…" , "C’mon, let’s go in!  +3"),
                            ("There are a lot of dudes who envy me because of that…" , "I’m… sorry?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Junpei seems a little embarrassed…" , "Where do guy friends go?  +2"),
                            ("He probably roasts them all differently, using special waters for each type…" , 
                            "You know a lot about coffee.  +3"),
                            ("What did you order, ...?" , "Hot cocoa.  +3"),
                            ("Haha, it’d be something right out of a manga." , "Maybe I should give it a try, then.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("What do you want to eat?" , "Ramen!  +2"),
                            ("There have to be some parents that their kids would be better off without…" , "That’s not true!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Junpei is awfully generous." , "Thanks for the food.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I’ll try asking my guy friends again, too. Wait right here." , "Thanks.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("You might be fine now, but you don’t wanna be a tub in 10 years, you know?" , "Shut it, jerk.  +3"),
                            ("Junpei seems to stare off into the distance…" , "You’ll be a great man.  +3"),
                            ("Junpei mutters as if to himself…" , "Your terrible jokes?  +3\nOR\nYour brown-nosing abilities?  +3"),
                            ("Do you ever think about what you can do…?" , "Of course.  +3\nOR\nSometimes.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Alright, I’m gonna do this today! I’m gonna overcome my fear of math!" , "You’re on fire!  +3"),
                            ("Haha!" , "You actually did it!  +3"),
                            ("Friends are important, after all…" , "I think I understand.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("I don’t think there’s going to be any more photos of you going around." , "You got them back for me?  +3"),
                            ("……" , "Junpei…  +3")
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
                Arcana = "Moon",
                // Male
                MaleName = "Nozomi Suemitsu",
                MaleUnlockDate = "After reaching Magician rank 4.",
                MaleHowToUnlock = "Must have Charm at level 3, answer his questions about food, and then give him an Odd Morsel.",
                MaleAvailability = "Can be found at Paulownia Mall every day during the day.",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("What's the most popular drink at the cafe over there?" , "Pheromone Coffee."),
                            ("What color is the mascot for Wild-duck Burger?" , "Green."),
                            ("What is the secret menu item at Hagakure?" , "Hagakure Bowl.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("So, how ‘bout it? Do you want to have me as a big brother?" , "Sure, okay.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("So, do you ‘get me’? Why would you say I was…?" , "You are the Gourmet King!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Nozomi looks pale." , "Oh, are you sick?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Right, ...?" , "Yeah, that’s right.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("I don’t get it. I felt fine up until just a minute ago…" , "Are you feeling sick?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Hope that wasn’t too freaky…" , "Wiped off the face of…!?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("I begged so hard for your soul that I think I even lost weight." , "Oh brother.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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
                FemaleName = "Shinjiro Aragaki",
                FemaleUnlockDate = "9/7",
                FemaleHowToUnlock = "Talk to him in the Dormitory Lounge at night.",
                FemaleAvailability = "",
                FemaleRequiresPersona = false,
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
                            ("Oh yeah... About Aki... In your opinion, do you think he's fighting well?" , "Yes, of course!  +3"),
                            ("But your powers look like they're helping a lot, too." , "I hope so...  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("So, I guess it might be better if they eat what makes them happy. But..." , "You're so kind-hearted.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("The taste brings back memories..." , "This is delicious.  +3\nOR\nI feel so lucky...  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("That's why I try not to come to these kinds of places that often." , "Why did we come here today?"),
                            ("......" , "I'm looking forward to it.  +3\nOR\nI'll help out too.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Shinjiro is skillfully cooking something while teaching Fuuka to make a different dish at the same time..." ,
                            "I'll help, too.  +3\nOR\nIs it ready yet?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Shinjiro shrugs..." , "I have my hopes up, too.  +3"),
                            ("How about you? Did you have fun too?" , "Definitely!  +3"),
                            ("Don't you have more fun things to do?" , "It's fun being with you.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Back then, I never imagined that I'd go back there..." , "I'm glad that you came back.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("C'mon, say something." , "Let's talk about something fun...  +3"),
                            ("So don't cry, got it...?" , "What're you trying to say?")
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
                Arcana = "Priestess",
                // Male
                MaleName = "Fuuka Yamagishi",
                MaleUnlockDate = "6/15",
                MaleHowToUnlock = "Courage must be level 2 and the Fortune Social Link must be at least rank 1.",
                MaleAvailability = "Can be found on the school's 2nd floor on Monday, Friday, and Saturday.",
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
                            ("Maybe I should give him some food. What do you think, ...-kun?" , "Sure.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Everything I make still tastes terrible..." , "I believe in you.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Not to mention that I'm kind of embarrassed about it all. I mean, it's not a very feminine hobby." ,
                            "Oh, I don't think so.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("W-Well, h-how does it taste?" , "You did a great job.  +3"),
                            ("You've taught me so much, ...-kun. Thank you for everything..." , "I'm glad I could help.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Just for a little while...?" , "Okay.  +3")
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
                            ("I want to be with you, ...-kun..." , "I want to be with you too.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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
                FemaleName = "Fuuka Yamagishi",
                FemaleUnlockDate = "6/15",
                FemaleHowToUnlock = "Courage must be level 2 and the Fortune Social Link must be at least rank 1.",
                FemaleAvailability = "Can be found on the school's 2nd floor on Monday, Thursday, and Saturday.",
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
                            ("Fuuka is muttering things to herself..." , "Do you need any help?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("So, you can relax a little too, ...-chan." , "Let's do our best.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("If only there was something I was actually good at..." , "You're good with machines.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("D-Do you think I can make something that difficult...?" , "Let's make it together.  +3"),
                            ("...Whenever I try that..." , "You did your best, too.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("H-How is it...?" , "You really did your best.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Seriously... I'm hopeless at everything..." , "Just try harder next time.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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
                Arcana = "Star",
                // Male
                MaleName = "Mamoru Hayase",
                MaleUnlockDate = "8/9",
                MaleHowToUnlock = "Talk to Mamoru at Iwatodai Strip Mall during the day after the sports meet.",
                MaleAvailability = "Can be found at Iwatodai Strip Mall during the day every day except Thursday. ",
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
                            ("Someday I'll be famous, and then I'll be the one sponsoring them!" , "I'm jealous.  +3"),
                            ("By the way, who do you consider your biggest rival?" , "Myself, really.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("You know what that means? If I do well enough, I might get a scholarship nod." ,
                            "Sounds like a good plan.  +2"),
                            ("I bet my mother would be really relieved." , "Yeah, I bet she would be.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("*pant* *pant* Sorry I kept you waiting... *gasp*" , "Are you okay?  +2"),
                            ("I used to come here a lot with my teammates, but..." , "We should come here again.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Sorry man, I don't think I can meet up with you today." , "Hey, no problem.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Thanks for coming down here..." , "I don't mind.  +2"),
                            ("...Is it really gonna end like this?" , "Don't give up!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Hmmm..." , "You should get some more.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("So, the big meet was yesterday." , "And you won?  +2"),
                            ("I got first place, of course!" , "Do a victory celebration.  +2"),
                            ("Order extra noodles. Go on, it's on me." , "Thank him for his generosity.  +2")
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
                FemaleName = "Akihiko Sanada",
                FemaleUnlockDate = "5/9",
                FemaleHowToUnlock = "Must have Charm at level 4.",
                FemaleAvailability = "Can be found in the 1F Laboratory Hallway on Monday and Friday.",
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
                            ("But, I'm drenched in sweat..." , "Don't catch a cold.  +2"),
                            ("You can't do a back hip circle, can you?" , "I bet you can't either, senpai!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...The combined power of the two girls glaring at you feels like your skin is being burned away." ,
                            "Let's go, Senpai!  +3"),
                            ("...What's the matter?" , "Yes, it was great.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Oh, no, it was just a rumor I heard. Sorry." , "Platonic\nIt's all right.  +3\n" +
                            "Romance\nDon't get the wrong idea, Senpai."),
                            ("If I hear anyone say that again, I'll tell them it's not true." , "Please do.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("....." , "Did you not like it?  +3"),
                            ("...Sorry about what happened back there." , "It's not your fault, Senpai.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Akihiko is absentmindedly watching them off..." , "He's just a child.  +3"),
                            ("Do you think I'm... strange?" , "Platonic\nYou're normal.  +2\nRomance\nYou're charming.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("No, that's not it, either. I guess... I get nervous." , "Do I seem unreliable?  +3"),
                            ("Akihiko sighs..." , "What's the matter?  +3\nOR\nShould I still be the leader?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Thanks for coming out today..." , "I'm happy to be with you.  +3"),
                            ("Akihiko's lips are trembling..." , "That's not true!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("That's a pity, since the wind is so nice right now." , "Do you come here often?  +3"),
                            ("...It's the weirdest thing." , "Platonic\nThat's just how things are.\nOR\nThat is pretty odd.\n" +
                            "Romance\nYou're in love."),
                            ("Will you be my girl?" , "Breaks Social Link\nI'm sorry, but...\nRomance\nYes!")
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
                Arcana = "Strength",
                // Male
                MaleName = "Yuko Nishiwaki",
                MaleUnlockDate = "4/28",
                MaleHowToUnlock = "Offer to walk Yuko home on ranks 2 and 3 of the Chariot Social Link.",
                MaleAvailability = "Can be found outside the classroom on Wednesday and Saturday.",
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
                            ("I'm mentally exhausted..." , "What happened?  +2"),
                            ("Right, ...-kun!?" , "I agree.  +3"),
                            ("My reputation as an 'intellectual' would be ruined. *blush*" , "That's true.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("Hey, ...-kun, do you think I eat too much?" , "Not really.  +2"),
                            ("You must love being around good-looking girls like Mitsuru and Yukari..." ,
                            "Not necessarily.  +2\nOR\nYou're much cuter, Yuko.  +2"),
                            ("Oh, shoot! It's already this late?" , "Let's go.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("I'm sorry, <protagonist>-kun... I didn't mean to get you involved." , "No worries.  +2"),
                            ("Are you mad?" , "I'm honored.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("I'm not as tall as you, so I can't walk as fast..." , "Hold her hand.  +2"),
                            ("Heeey!" , "Do you know him?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("So, what's your honest opinion? Can they win?" , "Let's hope for the best.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Well, there they go..." , "Are you relieved?  +2"),
                            ("Maybe we should have a little party... You know, to celebrate our first attempt at coaching..." ,
                            "Sure.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Would you want it to be a boy or a girl?" , "A boy.  +2\nOR\nA girl.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("C-Can we just forget about that?" , "Forget about what?  +2"),
                            ("Guess what I wanna be." , "An instructor?  +3")
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
                FemaleName = "Koromaru",
                FemaleUnlockDate = "8/15",
                FemaleHowToUnlock = "Priestess Social Link must be at least rank 1, then give Koromaru the Dog Food from Fuuka.",
                FemaleAvailability = "Can be found in the Dormitory Lounge every night.",
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
                            ("Woof." , "Does it feel good?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("There's a ball at Koromaru's feet..." , "Pick it up.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Arf." , "Can you do it boy?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Koromaru is sitting patiently..." , "We're with you.  +3"),
                            ("Other dogs return the howl from every direction..." , "Saying hi to the priest?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Koromaru is on guard as he watches the two leave..." , "It's all right now.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("Koromaru is wagging his tail happily..." , "Glad we found his owner.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("If you recall correctly, what you did was..." , "Brushed him.  +3"),
                            ("Where would you start brushing him...?" , "The back.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("The way Koromaru thinks of us is..." , "He sees us as friends.  +3")
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
                Arcana = "Sun",
                // Male
                MaleName = "Akinari Kamiki",
                MaleUnlockDate = "8/9",
                MaleHowToUnlock = "Academics must be level 4, the Hanged Man Social Link must be rank 3 to meet him. " +
                "Visit Akinari again and talk to him until he mentions his lost pen. Talk to Koromaru in the Dormitory " +
                "Lounge after he joins SEES to get the Red Fountain Pen, and then return the pen to Akinari.",
                MaleAvailability = "Can be found at Naganaki Shrine every Sunday during the day.",
                MaleRequiresPersona = false,
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
                            ("You're... not like the others." , "...Really?  +3"),
                            ("Dying isn't so unusual, is it? What is there to gain by staying in this world for a long time, anyway?" ,
                            "That's a good point.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...Why is this only happening to me?" , "I don't know.  +3"),
                            ("When I'm alone... it feels like it could end at any second." , "Try not to talk so much.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("...Do you read many books?" , "Yeah, I like reading.  +3"),
                            ("...Do you read books all the way to the end?" , "If it's boring, I stop reading.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("...I guess my condition won't improve if I keep taking chances, though." , "Reprimand Akinari.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Hey, how do you feel about a pink alligator?" , "Hey, that's cool.  +3"),
                            ("But, anyway... How does the story sound to you?" , "It sounds interesting.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("...That's as far as I've written. I haven't decided on an ending." , "It sounds really depressing.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Akinari is having trouble breathing." , "Stay at his side.  +3"),
                            ("It's not going to fix me anyway, right? ...It just helps for the pain and... ...spasming..." ,
                            "What are you thinking?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("So... I'd like you to congratulate me. As of today, I am a free individual." , 
                            "Oh, did you finish the story?  +3")
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
                FemaleName = "Akinari Kamiki",
                FemaleUnlockDate = "8/9",
                FemaleHowToUnlock = "Academics must be level 4, the Hanged Man Social Link must be rank 3 to meet him. " +
                "Visit Akinari again and talk to him until he mentions his lost pen. Talk to Koromaru in the Dormitory " +
                "Lounge after he joins SEES to get the Red Fountain Pen, and then return the pen to Akinari.",
                FemaleAvailability = "Can be found at Naganaki Shrine every Sunday during the day.",
                FemaleRequiresPersona = false,
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
                            ("You're... not like the others." , "You think so?  +3"),
                            ("Dying isn't so unusual, is it? What is there to gain by staying in this world for a long time, anyway?" ,
                            "You may be right.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...Why is this only happening to me?" , "I don't know.  +3"),
                            ("When I'm alone... it feels like it could end at any second." , "Talking makes it hurt worse.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("...Do you read many books?" , "I love reading!  +3"),
                            ("...Do you read books all the way to the end?" , "Not if it's boring.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("...I guess my condition won't improve if I keep taking chances, though." , "Don't push yourself!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Hey, how do you feel about a pink alligator?" , "That sounds wonderful.  +3"),
                            ("But, anyway... How does the story sound to you?" , "Sounds interesting.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("...That's as far as I've written. I haven't decided on an ending." , "It's a gloomy story.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Akinari is having trouble breathing." , "Stay at his side.  +3"),
                            ("It's not going to fix me anyway, right? ...It just helps for the pain and... ...spasming..." ,
                            "Why!?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("So... I'd like you to congratulate me. As of today, I am a free individual." , 
                            "You finished the story?  +3")
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
                Arcana = "Temperance",
                // Male
                MaleName = "Andre Laurent Jean Geraux (Bebe)",
                MaleUnlockDate = "5/29",
                MaleHowToUnlock = "Academics must be level 2, and Hierophant Social Link must be rank 3. " +
                "Has to be started before the third Full Moon or the Social Link will be missed.",
                MaleAvailability = "Can be found in or outside of the Home Economics Room on Tuesday, Wednesday, and " +
                "Friday.",
                MaleRankUps = new ObservableCollection<RankUp>
                {
                    new RankUp()
                    {
                        RankNumber = 1,
                        Questions = new List<(string, string)>
                        {
                            ("Any response.", "Any response.")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 2,
                        Questions = new List<(string, string)>
                        {
                            ("Zis is my first time going, so will you teach me?", "There's nothing to teach.  +3"),
                            ("I am so 'appy, ureshii! I love ze culture of Nihon! Japan eez sugoi, amazing!",
                            "Yeah, Japan is great.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...-sama, you 'ave gotten much better at zis! Subarashii! Wonderful!",
                            "Thanks.  +2"),
                            ("I would like to make somezing Japanese, but what?", "Something traditional?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Bebe, who's usually very talkative, is quiet.", "Are you alright?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("...Want to go somewhere to eat after zis?", "Sure.  +2"),
                            ("...my uncle might never let me return 'ere!", "Then, stay.  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Bebe seems confused.", "Take a break.  +2"),
                            ("Shall we!?", "Alright.  +2"),
                            ("I want to stay 'ere in Nihon even if I 'ave to eat dirt!", "Support him.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("I will show 'im a kimono, and make 'im understand the beauty of Nihon!",
                            "That's a good idea.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("When my uncle sees zis, I know he'll agree wiz me about how great Nihon eez!",
                            "He'll agree for sure.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("But because of you, ...-sama, I was able to finish ze kimono!",
                            "Congratulate him.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 10,
                        Questions = new List<(string, string)>
                        {
                            ("Any response.", "Any response.")
                        }
                    }
                },
                // Female
                FemaleName = "Andre Laurent Jean Geraux (Bebe)",
                FemaleUnlockDate = "5/6",
                FemaleHowToUnlock = "Academics must be level 2, and Hierophant Social Link must be rank 3. " +
                "Has to be started before the third Full Moon or the Social Link will be missed.",
                FemaleAvailability = "Can be found in or outside of the Home Economics Room on Tuesday, Wednesday, and " +
                "Friday.",
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
                            ("Zis is my first time going, so will you teach me?" , "There's nothing to teach.  +3"),
                            ("I am so 'appy, ureshii! I love ze culture of Nihon! Japan eez sugoi, amazing!" ,
                            "It sure is!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...-sama, you 'ave gotten much better at zis! Subarashii! Wonderful!" , "Thank you!  +3"),
                            ("I would like to make somezing Japanese, but what?" , "How about a kimono?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Bebe, who's usually very talkative, is quiet." , "You look down.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("Want to go somewhere to eat after zis?" , "Sure.  +3"),
                            ("...my uncle might never let me return 'ere!" , "Stay here.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Ze sewing machine won't go..." , "Why don't you rest?  +3"),
                            ("Shall we!?" , "That's a great idea.  +3"),
                            ("I want to stay 'ere in Nihon even if I 'ave to eat dirt!" , "I'm behind you.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("I will show 'im a kimono, and make 'im understand the beauty of Nihon!" ,
                            "It's a nice idea.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("When my uncle sees zis, I know he'll agree wiz me about how great Nihon eez!" ,
                            "He'll agree!  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("But because of you, ...-sama, I was able to finish ze kimono!" , "What is France like?  +3")
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
                Arcana = "Tower",
                // Male
                MaleName = "Mutatsu",
                MaleUnlockDate = "After Yuko mentions the monk in Club Escapade.",
                MaleHowToUnlock = "Strength Social Link must be rank 4, and Courage must be level 4. Talk to the Monk" +
                "in Club Escapade, then the bartender. The bartender will want to know the drink orders of the patrons." +
                "Give him the orders: Bloody Mary, Margarita, Screwdriver, and Oolong Tea. Go back to Mutatsu after.",
                MaleAvailability = "Can be found in Club Escapade on the 2nd floor on Thursday, Friday, Saturday," +
                "and Sunday nights.",
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
                            ("...So, what're you doin' here, kid?" , "None of your business.  +3"),
                            ("You don't have to revere me, but at least show me some respect." , "I'm sorry, um...  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...How come you're always alone when I see ya? Don'tcha got any friends, kid?" ,
                            "I don't have any friends.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("You should cut it. No, better yet, shave it all off... smooth like me." ,
                            "Yeah, that might look cool.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("High school kids don't have much money, do they? At least, I never gave much to my son." ,
                            "I have enough.  +2"),
                            ("Is there anything you want right now?" , "No.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Ugh... I'm in bad shape..." , "You should go home.  +3"),
                            ("It's times like these I wish I didn't live alone..." , "What about the others?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("...Hey! There's a microphone over there. Bring it over, kid! I'll perform a live sutra reading." ,
                            "I don't think you should.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Didn't Dad tell you not to do that, ehhh?" , "Dad?  +3"),
                            ("What the hell were ya doin' thish late!?" ,
                            "I was with a friend.  +3\nOR\nNone of your business.  +3"),
                            ("...Now when I go home, I don't know what to do with myself, so I just come here and drink every night." ,
                            "Are you running away?  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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
                FemaleName = "Mutatsu",
                FemaleUnlockDate = "After Yuko mentions the monk in Club Escapade.",
                FemaleHowToUnlock = "Chariot Social Link must be rank 3, and Courage must be level 4. Talk to the Monk " +
                "in Club Escapade, then the bartender. The bartender will want to know the drink orders of the patrons. " +
                "Give him the orders: Bloody Mary, Margarita, Screwdriver, and Oolong Tea. Go back to Mutatsu after.",
                FemaleAvailability = "Can be found in Club Escapade on the 2nd floor on Thursday, Friday, Saturday, " +
                "and Sunday nights.",
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
                            ("...So, what're you doin' here, kid?" , "I don't need to tell you.  +3"),
                            ("You don't have to revere me, but at least show me some respect." , "What should I call you?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 3,
                        Questions = new List<(string, string)>
                        {
                            ("...How come you're always alone when I see ya? Don'tcha got any friends, kid?" ,
                            "I have no friends.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 4,
                        Questions = new List<(string, string)>
                        {
                            ("Why don't ya give it a try? The bald look..." , "I've always wanted to try that.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 5,
                        Questions = new List<(string, string)>
                        {
                            ("High school kids don't have much money, do they? At least, I never gave much to my son." ,
                            "I get by.  +2"),
                            ("Is there anything you want right now?" , "There isn't.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 6,
                        Questions = new List<(string, string)>
                        {
                            ("Ugh... I'm in bad shape..." , "You should get home.  +3"),
                            ("It's times like these I wish I didn't live alone..." , "What about your workers?  +2")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 7,
                        Questions = new List<(string, string)>
                        {
                            ("...Hey! There's a microphone over there. Bring it over, kid! I'll perform a live sutra reading." ,
                            "You probably shouldn't.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 8,
                        Questions = new List<(string, string)>
                        {
                            ("Didn't Dad tell you not to do that, ehhh?" , "Dad?  +3"),
                            ("What the hell were ya doin' thish late!?" ,
                            "I was with friends.  +3\nOR\nI don't need to tell you!  +3"),
                            ("...Now when I go home, I don't know what to do with myself, so I just come here and drink every night." ,
                            "You're just running away.  +3")
                        }
                    },
                    new RankUp()
                    {
                        RankNumber = 9,
                        Questions = new List<(string, string)>
                        {
                            ("Any response." , "Any response.")
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

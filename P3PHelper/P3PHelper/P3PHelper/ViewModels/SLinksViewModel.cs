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
                            ("Have you ever wondered what it would be like to be able to see through people’s bathing suits at the beach?" , "I sure have!  +3")
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
                            ("Have you ever wondered what it would be like to be able to see through people’s bathing suits at the beach?" ,
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
                            ("Sorry for subjecting you to my incoherent ramblings… Please forget what I just said." , "Okay, I will.  +2")
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

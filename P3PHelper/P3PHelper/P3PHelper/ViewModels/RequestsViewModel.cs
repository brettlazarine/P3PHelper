using P3PHelper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace P3PHelper.ViewModels
{
    public class RequestsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand ToggleDetailsCommand { get; private set; }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<Request> RequestCollection { get; set; }

        public RequestsViewModel()
        {
            //Create the collection of requests
            RequestCollection = new ObservableCollection<Request>() 
            {
                req1, req2, req3, req4, req5, req6, req7, req8, req9, req10,
                req11, req12, req13, req14, req15, req16, req17, req18, req19, req20,
                req21, req22, req23, req24, req25, req26, req27, req28, req29, req30,
                req31, req32, req33, req34, req35, req36, req37, req38, req39, req40,
                req41, req42, req43, req44, req45, req46, req47, req48, req49, req50,
                req51, req52, req53, req54, req55, req56, req57, req58, req59, req60,
                req61, req62, req63, req64, req65, req66, req67, req68, req69, req70,
                req71, req72, req73, req74, req75, req76, req77, req78, req79, req80
            };
            ToggleDetailsCommand = new Command<Request>(ExecuteToggleDetailsCommand);

            //foreach (var req in RequestCollection)
            //{
            //    req.IsCompleted = Preferences.Get("Request_IsCompleted_" + req.Number, false);
            //}
        }

        private void ExecuteToggleDetailsCommand(Request request)
        {
            request.AreDetailsVisible = !request.AreDetailsVisible;
        }

        #region 1-10
        readonly Request req1 = new Request()
        {
            Number = 1,
            Name = "a",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req2 = new Request()
        {
            Number = 2,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req3 = new Request()
        {
            Number = 3,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req4 = new Request()
        {
            Number = 4,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req5 = new Request()
        {
            Number = 5,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req6 = new Request()
        {
            Number = 6,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req7 = new Request()
        {
            Number = 7,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req8 = new Request()
        {
            Number = 8,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req9 = new Request()
        {
            Number = 9,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req10 = new Request()
        {
            Number = 10,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion  

        #region 11-20
        Request req11 = new Request()
        {
            Number = 11,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req12 = new Request()
        {
            Number = 12,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req13 = new Request()
        {
            Number = 13,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req14 = new Request()
        {
            Number = 14,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req15 = new Request()
        {
            Number = 15,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req16 = new Request()
        {
            Number = 16,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req17 = new Request()
        {
            Number = 17,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req18 = new Request()
        {
            Number = 18,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req19 = new Request()
        {
            Number = 19,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req20 = new Request()
        {
            Number = 20,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion

        #region 21-30
        Request req21 = new Request()
        {
            Number = 21,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req22 = new Request()
        {
            Number = 22,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req23 = new Request()
        {
            Number = 23,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req24 = new Request()
        {
            Number = 24,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req25 = new Request()
        {
            Number = 25,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req26 = new Request()
        {
            Number = 26,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req27 = new Request()
        {
            Number = 27,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req28 = new Request()
        {
            Number = 28,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req29 = new Request()
        {
            Number = 29,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req30 = new Request()
        {
            Number = 30,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion

        #region 31-40
        Request req31 = new Request()
        {
            Number = 31,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req32 = new Request()
        {
            Number = 32,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req33 = new Request()
        {
            Number = 33,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req34 = new Request()
        {
            Number = 34,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req35 = new Request()
        {
            Number = 35,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req36 = new Request()
        {
            Number = 36,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req37 = new Request()
        {
            Number = 37,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req38 = new Request()
        {
            Number = 38,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req39 = new Request()
        {
            Number = 39,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req40 = new Request()
        {
            Number = 40,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion

        #region 41-50
        Request req41 = new Request()
        {
            Number = 41,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req42 = new Request()
        {
            Number = 42,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req43 = new Request()
        {
            Number = 43,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req44 = new Request()
        {
            Number = 44,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req45 = new Request()
        {
            Number = 45,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req46 = new Request()
        {
            Number = 46,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req47 = new Request()
        {
            Number = 47,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req48 = new Request()
        {
            Number = 48,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req49 = new Request()
        {
            Number = 49,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req50 = new Request()
        {
            Number = 50,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion

        #region 51-60
        Request req51 = new Request()
        {
            Number = 51,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req52 = new Request()
        {
            Number = 52,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req53 = new Request()
        {
            Number = 53,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req54 = new Request()
        {
            Number = 54,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req55 = new Request()
        {
            Number = 55,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req56 = new Request()
        {
            Number = 56,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req57 = new Request()
        {
            Number = 57,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req58 = new Request()
        {
            Number = 58,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req59 = new Request()
        {
            Number = 59,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req60 = new Request()
        {
            Number = 60,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion

        #region 61-70
        Request req61 = new Request()
        {
            Number = 61,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req62 = new Request()
        {
            Number = 62,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req63 = new Request()
        {
            Number = 63,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req64 = new Request()
        {
            Number = 64,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req65 = new Request()
        {
            Number = 65,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req66 = new Request()
        {
            Number = 66,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req67 = new Request()
        {
            Number = 67,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req68 = new Request()
        {
            Number = 68,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req69 = new Request()
        {
            Number = 69,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req70 = new Request()
        {
            Number = 70,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion

        #region 71-80
        Request req71 = new Request()
        {
            Number = 71,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req72 = new Request()
        {
            Number = 72,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req73 = new Request()
        {
            Number = 73,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req74 = new Request()
        {
            Number = 74,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req75 = new Request()
        {
            Number = 75,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req76 = new Request()
        {
            Number = 76,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req77 = new Request()
        {
            Number = 77,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req78 = new Request()
        {
            Number = 78,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req79 = new Request()
        {
            Number = 79,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        Request req80 = new Request()
        {
            Number = 80,
            Name = "",
            HowToUnlock = "",
            ExpiresDate = "",
            Solution = "",
            Reward = ""
        };
        #endregion
    }
}

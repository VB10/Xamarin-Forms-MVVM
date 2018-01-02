using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HardawreAndroMVVM.User
{
    public class Userx : INotifyPropertyChanged
    {
        string UserName;

        public string userName
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
                OnPropertyChanged("userName");
                OnPropertyChanged("fullName");
            }
        }
        string UserSurname;


        public string userSurname
        {
            get
            {
                return UserSurname;
            }

            set
            {
                UserSurname = value;
                OnPropertyChanged("userSurname");
                OnPropertyChanged("fullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string fullName
        {
            get {
                return userName + " : " + userSurname;
            }
        }



        protected virtual void OnPropertyChanged([CallerMemberName]string propname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}

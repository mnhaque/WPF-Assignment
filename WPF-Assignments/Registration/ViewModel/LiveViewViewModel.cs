using Common;
using Prism.Events;
using Registration.BusinessLayer;
using Registration.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Registration.ViewModel
{
    public class LiveViewViewModel : INotifyPropertyChanged
    {
        private string name;
        private string dob;
        private IEventAggregator eventAggregator;

        public LiveViewViewModel()
        {
            eventAggregator = Event.EventInstance.EventAggregator;
            this.eventAggregator.GetEvent<PubSubEvent<User>>().Subscribe((user) => {
                this.Name = user.Name;
                this.DOB = user.DOB;
            });
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }
        public string DOB
        {
            get
            {
                return this.dob;
            }
            set
            {
                dob = value;
                RaisePropertyChanged(nameof(DOB));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

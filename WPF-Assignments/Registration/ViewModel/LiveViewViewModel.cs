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
        private DateTime? dob;
        private IEventAggregator eventAggregator;

        public LiveViewViewModel()
        {
            eventAggregator = Event.EventInstance.EventAggregator;
            this.eventAggregator.GetEvent<PubSubEvent<string>>().Subscribe((name) => {
                this.Name = name;
            });
            this.eventAggregator.GetEvent<PubSubEvent<DateTime?>>().Subscribe((dob) => {
                this.DOB = dob;
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
        public DateTime? DOB
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

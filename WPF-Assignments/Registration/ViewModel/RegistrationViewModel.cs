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
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private IUserService userService;
        private string name;
        private string dob;
        public ICommand submit;
        private IEventAggregator eventAggregator;
        private void SaveRecord(object param)
        {
            if (userService == null)
            {
                userService = new UserService();
            }
            if (!string.IsNullOrWhiteSpace(Name))
            {
                var response = userService.SaveUser(new User { Name = Name, DOB = DOB });
                if (true)
                {
                    MessageBox.Show("user added successfully");
                }
            }
            else
            {
                MessageBox.Show("name is blank");
            }
        }

        public RegistrationViewModel()
        {
            eventAggregator = Event.EventInstance.EventAggregator;
            this.userService = new UserService();
            submit = new RelayCommand(SaveRecord);
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

        public ICommand Submit { get { return submit; } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
                this.eventAggregator.GetEvent<PubSubEvent<User>>().Publish(new User { Name = Name, DOB = DOB });
            }
        }
    }
}

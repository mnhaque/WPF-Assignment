using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Registration.BusinessLayer;
using Registration.Model;

namespace Registration.ViewModel
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private UserService userService;
        private string name;
        private DateTime dob;
        public ICommand submit;
        private void SaveRecord(object param)
        {
            if (userService == null)
            {
                userService = new UserService();
            }
            if (!string.IsNullOrWhiteSpace(Name))
            {
                var response = userService.SaveUser(new User {Name = Name, DOB = DOB});
                if (response)
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
        public DateTime DOB
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
            }
        }
    }
}

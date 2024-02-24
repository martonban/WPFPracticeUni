using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFwithMVVMDemo.Models;

namespace WPFwithMVVMDemo.ViewModels {
	public class ShellViewModel : Screen {

		private string _firstName;
		private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel(){
			People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
			People.Add(new PersonModel { FirstName = "Bill", LastName = "Jhones" });
			People.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
        }

        public string FirstName {
			get { return _firstName; }
			set {
				_firstName = value;
				// If there is any changes like a TextBlock has been changed the data will be rewritten
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string LastName {
			get { return _lastName; }
			set {
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string FullName {
			get { return $"{FirstName} {LastName}"; }
		}

		public BindableCollection<PersonModel> People {
			get { return _people; }
			set { _people = value; }
		}

		public PersonModel SelectedPerson {
			get { return _selectedPerson; }
			set { 
				_selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
		}

		public void ClearText() {
			FirstName = "";
			LastName = "";
		}
	}
}

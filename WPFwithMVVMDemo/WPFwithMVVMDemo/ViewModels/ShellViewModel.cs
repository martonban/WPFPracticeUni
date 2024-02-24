using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFwithMVVMDemo.ViewModels {
    public class ShellViewModel : Screen {

		private string _firstName = "Tim";
        private string _lastName;

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

	}
}

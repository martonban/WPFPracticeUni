using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilderPracticeMVVM.Models;

namespace TeamBuilderPracticeMVVM.ViewModels {
    public class TeamViewModel {
        BindableCollection<String> _defaultValues = new BindableCollection<String>();

        public TeamViewModel() {
            _defaultValues.Add("0-5");
            _defaultValues.Add("5-10");
            _defaultValues.Add("10-100");
            _defaultValues.Add("100-1000");
            _defaultValues.Add("1000-10000");
        }

    }
}

using Prac7._1.Model;
using Prac7._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Prac7._1.ViewModel
{
    internal class BuyPageVM : BindingHelper
    { 
        private Marmelade selected = new Marmelade();

        public Marmelade Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Marmelade> marmelade;

        public ObservableCollection<Marmelade> Marmelade
        {
            get { return marmelade; }
            set
            {
                marmelade = value;
                OnPropertyChanged();
            }
        }
        public BuyPageVM()
        {
            Marmelade = new ObservableCollection<Marmelade>()
            {
                new Marmelade("asdaaaa","asdd",123)
            };
        }
    }
}


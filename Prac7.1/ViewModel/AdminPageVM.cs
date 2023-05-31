using Prac7._1.Model;
using Prac7._1.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;
using _123;
using mblib;

namespace Prac7._1.ViewModel
{
    #region свойства
    internal class AdminPageVM: BindingHelper
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
		public AdminPageVM()
		{
			
			Marmelade = Class1.MyDeserialize<ObservableCollection<Marmelade>>();
			AddCommand = new BindableCommand(_=> AddItems());
			DeleteCommand = new BindableCommand(_ => DeleteItems());
			Serialize = new BindableCommand(_ => SerializeItems());
		}
		#endregion

		#region жетские комманд
		public void AddItems()
		{
			Marmelade.Add(Selected);
			Selected =  new Marmelade();
			Class2.MbAdd();
		}
	
        public void DeleteItems()
        {
            if (Selected != null)
            {
                Marmelade.Remove(Selected);
				Class2.MbDel();
            }
        }

		public void SerializeItems()
		{
			Class1.MySerialize(Marmelade);
			Class2.MbSer();
		}
		#endregion
		
		#region Bindable shit
		public BindableCommand AddCommand { get; set; }
        public BindableCommand DeleteCommand { get;set; }
		public BindableCommand Serialize { get; set; }
		public BindableCommand Deserialize { get; set; }


        #endregion

    }
}

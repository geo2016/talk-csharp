using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfDataBind
{
    class Animal:INotifyPropertyChanged
    {
        private string _disp;
        public string Disp { 
            get => _disp;
            set {
                _disp = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Disp"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

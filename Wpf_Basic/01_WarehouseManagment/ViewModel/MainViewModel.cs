using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _01_WarehouseManagment.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool IsShow { get; set; }
        public MainViewModel()
        {
            if(!IsShow)
            {
                IsShow = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}

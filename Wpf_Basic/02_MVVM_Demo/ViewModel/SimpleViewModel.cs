using _02_MVVM_Demo.Model;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace _02_MVVM_Demo.ViewModel
{
    public class SimpleViewModel : BindableBase
    {
        #region Properties
        private int _firstNumber;
        public int FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                SetProperty(ref _firstNumber, value);
                SubmitCommand.RaiseCanExecuteChanged();
            }
        }
        private int _secondNumber;
        public int SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                SetProperty(ref _secondNumber, value);
                SubmitCommand.RaiseCanExecuteChanged();
            }
        }
        private int _sum;
        public int Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                SetProperty(ref _sum, value);
            }
        }
        /// <summary>
        /// List Sum binding to DataGrid
        /// </summary>
        private ObservableCollection<SimpleClass> _lstSum;
        public ObservableCollection<SimpleClass> lstSum
        {
            get
            {
                return _lstSum;
            }
            set
            {
                SetProperty(ref _lstSum, value);
            }
        }
        #endregion

        #region Command
        public DelegateCommand SubmitCommand { get; set; }
        private void OnSubmit()
        {
            Sum = FirstNumber + SecondNumber;
            lstSum.Add(new SimpleClass { a = FirstNumber, b = SecondNumber, sum = Sum });
        }
        private bool CanSubmit()
        {
            if(FirstNumber != 0 && SecondNumber != 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        public SimpleViewModel()
        {
            this.SubmitCommand= new DelegateCommand(OnSubmit, CanSubmit);
            //Khoi tao du lieu ban dau cho DataGrid
            SimpleClass temp = new SimpleClass();
            lstSum = new ObservableCollection<SimpleClass>(temp.InitData());
        }
    }
}

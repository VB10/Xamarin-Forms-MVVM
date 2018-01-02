using HardawreAndroMVVM.User;
using Xamarin.Forms;

namespace HardawreAndroMVVM
{
    public partial class HardawreAndroMVVMPage : ContentPage
    {
        public HardawreAndroMVVMPage()
        {
            InitializeComponent();


            BindingContext = new Userx();
          
        }
    }
}

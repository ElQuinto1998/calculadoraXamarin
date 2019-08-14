using Android.Widget;
using Calculadora.Droid;
using Xamarin.Forms;
using Message = CalculatePage.Message;

[assembly: Dependency(typeof(IMessage))]
namespace Calculadora.Droid
{
    public class IMessage : Message
    {
        public void LongTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}
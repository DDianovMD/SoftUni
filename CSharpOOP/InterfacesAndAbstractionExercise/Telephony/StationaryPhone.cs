using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
            if (phoneNumber.All(x => char.IsDigit(x)))
            {
                return $"Dialing... {phoneNumber}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}

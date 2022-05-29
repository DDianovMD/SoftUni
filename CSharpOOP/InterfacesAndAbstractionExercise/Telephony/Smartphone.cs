using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {        
        public string Call(string phoneNumber)
        {           
            if (phoneNumber.All(x => char.IsDigit(x)))
            {
                return $"Calling... {phoneNumber}";
            }
            else
            {
                return "Invalid number!";
            }
        }

        public string Browse(string site)
        {            
            if (site.Any(x => char.IsDigit(x)))
            {
                return $"Invalid URL!";
            }
            else
            {
                return $"Browsing: {site}!";
            }
        }
    }
}

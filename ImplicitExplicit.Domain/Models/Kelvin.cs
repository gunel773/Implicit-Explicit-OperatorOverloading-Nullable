

namespace ImplicitExplicit.Domain.Models
{
    public class Kelvin
    {
        public double K { get; set; }
        public Kelvin(double k)
        {
            K = k;
        }
        public static implicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.K - 273.15);
        }

    }
}

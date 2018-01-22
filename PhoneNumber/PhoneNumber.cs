namespace jkulubya.UG
{
    public class PhoneNumber
    {
        public PhoneNumber(string countryCode, string localPortion)
        {
            CountryCode = countryCode;
            LocalPortion = localPortion;
        }

        public string CountryCode { get; }

        public string LocalPortion { get; }

        public override string ToString()
        {
            return $"{CountryCode}{LocalPortion}";
        }
    }
}
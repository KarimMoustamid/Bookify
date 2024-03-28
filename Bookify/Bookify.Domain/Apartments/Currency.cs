namespace Bookify.Domain.Apartments
{
    public record Currency()
    {
        internal readonly static Currency None = new("");
        public readonly static Currency Usd = new("USD");
        public readonly static Currency Eur = new("EUR");

        private Currency(string code) : this() => Code = code;
        public string Code { get; init; }

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code) ??
                   throw new ApplicationException("The currency code is invalid");
        }

        public readonly static IReadOnlyCollection<Currency> All = new[]
        {
            Usd,
            Eur
        };
    }
}
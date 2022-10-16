using System.Text;

namespace StockMarket
{
    public class Stock
    {
        private string companyName;
        private string director;
        private decimal pricePerShare;
        private int totalNumberOfShares;
        private decimal marketCapitalization;

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;
            this.MarketCapitalization = this.PricePerShare * this.TotalNumberOfShares;
        }

        public string CompanyName { get => this.companyName; set => this.companyName = value; }
        public string Director { get => this.director; set => this.director = value; }
        public decimal PricePerShare { get => this.pricePerShare; set => this.pricePerShare = value; }
        public int TotalNumberOfShares { get => this.totalNumberOfShares; set => this.totalNumberOfShares = value; }
        public decimal MarketCapitalization { get => this.marketCapitalization; set => this.marketCapitalization = value; }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Company: {this.CompanyName}");
            result.AppendLine($"Director: {this.Director}");
            result.AppendLine($"Price per share: ${this.PricePerShare}");
            result.AppendLine($"Market capitalization: ${this.MarketCapitalization}");
           
            return result.ToString().Trim();
        }
    }
}

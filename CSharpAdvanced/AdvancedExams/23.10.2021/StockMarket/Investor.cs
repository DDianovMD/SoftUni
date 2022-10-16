using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio = new List<Stock>();
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
        }

        public string FullName { get => this.fullName; set => this.fullName = value; }
        public string EmailAddress { get => this.emailAddress; set => this.emailAddress = value; }
        public decimal MoneyToInvest { get => this.moneyToInvest; set => this.moneyToInvest = value; }
        public string BrokerName { get => this.brokerName; set => this.brokerName = value; }
        public int Count { get => this.Portfolio.Count; }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10_000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.MoneyToInvest -= stock.PricePerShare;
                this.Portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            bool isExisting = false;
            Stock stockForSale = null;

            foreach (Stock stock in Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    isExisting = true;
                    stockForSale = stock;
                    break;
                }
            }

            if (isExisting)
            {
                if (stockForSale.PricePerShare > sellPrice)
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    this.MoneyToInvest += sellPrice;
                    this.Portfolio.Remove(stockForSale);

                    return $"{companyName} was sold.";
                }
            }
            else
            {
                return $"{companyName} does not exist.";
            }
        }

        public Stock FindStock(string companyName)
        {
            Stock result = null;

            foreach (Stock stock in this.Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    result = stock;
                    break;
                }
            }

            return result;
        }

        public Stock FindBiggestCompany()
        {
            if (this.Count == 0)
            {
                return null;
            }
            else
            {
                Stock result = this.Portfolio.OrderByDescending(stock => stock.MarketCapitalization).ElementAt(0);

                return result;
            }
        }

        public string InvestorInformation()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");
            foreach (Stock stock in this.Portfolio)
            {
                result.AppendLine(stock.ToString());
            }

            return result.ToString().Trim();
        }
    }
}

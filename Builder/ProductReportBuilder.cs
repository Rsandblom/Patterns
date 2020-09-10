using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class ProductReportBuilder : IProductReportBuilder
    {
        private ProductReport _productReport;
        private IEnumerable<Product> _products;

        public List<Product> Products => _products.ToList(); 

        public ProductReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productReport = new ProductReport();
        }

        public void BuildHeader()
        {
            _productReport.HeaderPart = $"REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
        }

        public void BuildBody()
        {
            _productReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => $"Product Referens: {p.Ref}, product lot number: {p.LotNr}, product quantity: {p.Quantity}"));
        }

        public void BuildSummation()
        {
            int productSum = _products.Sum(p => p.Quantity);
            _productReport.SummationPart = $"Total number of products: {productSum}\n";
        }

        public void BuildFooter()
        {
            _productReport.FooterPart = "\nReport provided by the IT_PRODUCTS company.";
            
        }

        public ProductReport GetReport()
        {
            var productReport = _productReport;
            //Clear();
            return productReport;
        }
    }
}

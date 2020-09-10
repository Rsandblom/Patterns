using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ProductReportDirector
    {
        private readonly IProductReportBuilder _productReportBuilder;
        public ProductReportDirector(IProductReportBuilder productReportBuilder)
        {
            _productReportBuilder = productReportBuilder;
        }
        public void BuildSimpleReport()
        {
            _productReportBuilder.BuildHeader();
            _productReportBuilder.BuildBody();
        }

        public void BuildFullReport()
        {
            _productReportBuilder.BuildHeader();
            _productReportBuilder.BuildBody();
            _productReportBuilder.BuildSummation();
            _productReportBuilder.BuildFooter();
        }

    }
}

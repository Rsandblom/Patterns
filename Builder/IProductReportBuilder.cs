using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IProductReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildSummation();
        void BuildFooter();
        ProductReport GetReport();
    }
}

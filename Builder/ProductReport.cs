using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ProductReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string SummationPart { get; set; }
        public string FooterPart { get; set; }

        public override string ToString() =>
            new StringBuilder()
                .AppendLine(HeaderPart)
                .AppendLine(BodyPart)
                .AppendLine(SummationPart)
                .AppendLine(FooterPart)
                .ToString();
        
    }
}

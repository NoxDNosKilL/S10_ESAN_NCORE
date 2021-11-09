using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_ESAN_NETCORE.Domain.Core.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }

        public class ProductPriceDTO
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public decimal? UnitPrice { get; set; }
        }

    }
}

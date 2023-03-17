using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class ProductInCategory
    {
        //public DateTime PublicationDate { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; } // bảng trung gian giữa 2 bảng phải thêm dòng này

        public int CategoryId { get; set; }

        public Category Category { get; set; } // bảng trung gian giữa 2 bảng phải thêm dòng này

    }
}

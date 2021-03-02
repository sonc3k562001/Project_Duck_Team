using System.Collections.Generic;


namespace DrinkStores.Models.ViewModels
{
    public class ProductsListViewModel
    {
        //tạo view cho model data 
        public IEnumerable<Product> Products { get; set; } //danh sách dữ liệu
        public PagingInfo PagingInfo { get; set; }//phân trang
        public string CurrentCategory { get; set; }

    }
}

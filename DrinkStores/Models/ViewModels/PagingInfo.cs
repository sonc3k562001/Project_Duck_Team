using System;
namespace DrinkStores.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }   // tổng số sản phẩm
        public int ItemsPerPage { get; set; } //  số sản phẩm nỗi Page
        public int CurrentPage { get; set; } // page hiện tại
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);// tổng số page

    }
}

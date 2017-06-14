using System;

namespace SportsStore.Models.ViewModels
{
    // “A view model class...is used specifically to pass data between a controller and a view.” 
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}

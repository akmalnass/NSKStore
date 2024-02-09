using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NSKStore.Models
{
    public class ProductCategoryViewModel
    {
        public List<Products>? Products { get; set; }
        public SelectList? Category { get; set; }
        public string? productCategory { get; set; }
        public string? SearchString { get; set; }
    }
}

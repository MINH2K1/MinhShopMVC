namespace MinhShopMVC.Models
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public int? Status { set; get; }

        public List<ProductInCategory>? ProductInCategories { get; set; }


    }
}

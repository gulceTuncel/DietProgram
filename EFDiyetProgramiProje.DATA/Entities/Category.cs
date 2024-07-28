namespace EFDiyetProgramiProje.DATA.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}
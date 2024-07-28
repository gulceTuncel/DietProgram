namespace EFDiyetProgramiProje.DATA.Entities
{
    public class CategoryPortion : BaseEntity
    {
        public int CategoryID { get; set; }
        public int PortionSizeID { get; set; }

        //Navigation Properties
        public virtual Category Category { get; set; }
        public virtual PortionSize PortionSize { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}

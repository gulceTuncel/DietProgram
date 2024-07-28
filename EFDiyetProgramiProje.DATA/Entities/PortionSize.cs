namespace EFDiyetProgramiProje.DATA.Entities
{
    public class PortionSize : BaseEntity
    {
        public string PortionDescription { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}
namespace EFDiyetProgramiProje.DATA.Entities
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Fats { get; set; }
        public decimal Proteins { get; set; }
        public decimal Carbs { get; set; }
        public decimal Calories { get; set; }
        public byte[]? Picture { get; set; }
        public int CategoryID { get; set; }
        public int PortionID { get; set; }

        public virtual Category Category { get; set; }
        public virtual PortionSize Portion { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
    }
}
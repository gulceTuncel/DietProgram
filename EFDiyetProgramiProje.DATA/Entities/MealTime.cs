namespace EFDiyetProgramiProje.DATA.Entities
{
    public class MealTime : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<UserFood> UserFoods { get; set; }
    }
}

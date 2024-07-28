namespace EFDiyetProgramiProje.DATA.Entities
{
    public class UserFood : BaseEntity
    {

        public int UserID { get; set; }
        public int FoodID { get; set; }
        public int MealTimeID { get; set; }
        public decimal PortionQuantity { get; set; }
        public decimal CaloriesTaken { get; set; }

        //Navigation Properties
        public virtual User User { get; set; }
        public virtual Food Food { get; set; }
        public virtual MealTime MealTime { get; set; }
    }
}

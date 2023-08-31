namespace StoreCurso.Model
{
    public class Item : BaseClass
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Item() : base(0, "")
        {
            
        }
    }
}
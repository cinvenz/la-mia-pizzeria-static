namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public Pizza() { }

        public Pizza( string name, string description, string image, double price)
        {
            this.Name = name;
            this.Description = description; 
            this.Image = image;   
            this.Price = price;
        }
    }
}

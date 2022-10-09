namespace MVC_Katherine_Project.Models
{
    public class Property
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Rooms { get; set; }
        public int Meters { get; set; }

        public int Bathroom { get; set; }

        public Boolean Lift { get; set; }

        public decimal Price { get; set; }

        public Property(int id, string name, int rooms, int meters, int bathroom, bool lift, decimal price)
        {
            Id = id;
            Name = name;
            Rooms = rooms;
            Meters = meters;
            Bathroom = bathroom;
            Lift = lift;
            Price = price;
        }

        public Property() { }



    }
}

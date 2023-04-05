namespace CodingEvents.Models
{
    public class EventCatagory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public EventCatagory()
        {
        }

        public EventCatagory(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is EventCatagory catagory &&
                   Id == catagory.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string? ToString()
        {
            return Name;
        }
    }
}

using System.Globalization;

namespace ModuloGenerics.Entities
{
    class Product : IComparable<Product>
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string description, double price)
        {
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return Description
                + " " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Product? other)
        {
            return Price.CompareTo(other.Price);
        }

        public override bool Equals(object? obj)
        {
            return Description.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }
    }
}


namespace Modulo12_Interfaces.Entitities
{
    class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }


    }
}

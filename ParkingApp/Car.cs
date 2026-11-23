namespace ParkingApp
{
    public class Car
    {
        private string plate;
        private string owner;

        public Car(string plate, string owner)
        {
            this.plate = plate;
            this.owner = owner;
        }

        public string GetPlate()
        {
            return plate;
        }

        public void SetPlate(string plate)
        {
            this.plate = plate;
        }

        public string GetOwner()
        {
            return owner;
        }

        public void SetOwner(string owner)
        {
            this.owner = owner;
        }
    }
}

namespace RentProject.Models
{
    public class Car
    {
        public int CarId { get; set; }

        public string CarOwnerID { get; set; }

        public string Title { get; set; }

        public string Brand { get; set; }

        public string CarModel { get; set; }

        public byte[] CarImage { get; set; }
        public int Year { get; set; }

        public int Km { get; set; }

        public string CarAddress { get; set; }

        public string FuelType { get; set; }

        public string GearType { get; set; }

        public int MotorPower { get; set; }


    }
}

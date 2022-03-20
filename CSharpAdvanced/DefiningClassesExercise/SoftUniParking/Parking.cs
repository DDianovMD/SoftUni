using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;
        public int Count
        {
            get
            {
                return this.cars.Count();
            }
        }


        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();
        }

        // Methods

        public string AddCar(Car car)
        {
            bool carExists = false;           

            if (this.cars.Count > 0)
            {
                foreach (var vehicle in this.cars)
                {
                    if (vehicle.Key == car.RegistrationNumber)
                    {
                        carExists = true;
                        break;
                    }
                }
            }

            if (carExists)
            {
                return "Car with that registration number, already exists!";
            }
            else
            {
                if (this.cars.Count == capacity)
                {
                    return "Parking is full!";
                }

                this.cars.Add(car.RegistrationNumber, car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            bool carExists = false;

            foreach (var vehicle in cars)
            {
                if (vehicle.Key == registrationNumber)
                {
                    carExists = true;
                }
            }

            if (carExists)
            {
                cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                cars.Remove(number);
            }
        }
    }
}

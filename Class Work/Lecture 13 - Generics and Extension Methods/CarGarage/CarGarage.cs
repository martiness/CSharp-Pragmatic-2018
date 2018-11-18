using System.Collections.Generic;

namespace CarGarage
{
    public class CarGarage
    {
        private readonly List<Car> _cars;

        public List<Car> Cars
        {
            get
            {
                return _cars;
            }
        }

        public CarGarage()
        {
            _cars = new List<Car>();
        }

        public void TakeNewCar(Car car)
        {
            _cars.Add(car);

            // example for extension methods
            //
            // _cars.ToArray<Car>();
            //      same as 
            // Enumerable.ToArray<Car>(_cars);

            // we can add ONLY cars if _cars is non-generic ArrayList
            // _cars.Add(new PetrolEngine());
            // _cars.Add(7.77);
        }

        public void RepairCar(int pos)
        {
            var car = _cars[pos];

            car.ChangeOil();
            car.ChangeTires();
        }

        public void ReturnCar(int pos)
        {
            _cars.RemoveAt(pos);
        }
    }
}
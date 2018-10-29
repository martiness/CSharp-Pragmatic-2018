namespace HomeWorkObjects
{
    public class Car
    {
        private string _carBrand;
        private string _carModel;
        private double _carMileAge;
        private double _carPrice;

        public string CarBrand
        {
            get
            {
                return this._carBrand;
            }
            set
            {
                this._carBrand = value;
            }
        }

        public string CarModel
        {
            get
            {
                return this._carModel;
            }
            set
            {
                this._carModel = value;
            }
        }

        public double CarMileage
        {
            get
            {
                return this._carMileAge;
            }
            set
            {
                this._carMileAge = value;
            }
        }

        public double CarPrice { get => _carPrice; set => _carPrice = value; }

        public Car()
        {
            this._carBrand = null;
            this._carModel = null;
            this._carMileAge = 0;
            this._carPrice = 0;
        }

        public Car(string carBrand) : this()
        {
            this._carBrand = carBrand;
            // How to add Car() to initialize other properties???
        }

        public Car(string carBrand, string carModel) : this(carBrand)
        {
            // How to use Car() to initialize already initialized properties???
            //this.carBrand = carBrand;
            this._carModel = carModel;
        }

        public Car(string carBrand, string carModel, double carMileAge) : this (carBrand, carModel)
        {
            // Can I add verification for double here: double.TryPrace ???
            //this.carBrand = carBrand;
            //this.carModel = carModel;
            this._carMileAge = carMileAge;
        }

        public Car(string carBrand, string carModel, double carMileAge, double carPrice) : this (carBrand, carModel, carMileAge)
        {
            //this.carBrand = carBrand;
            //this.carModel = carModel;
            //this.carMileAge = carMileAge;
            this._carPrice = carPrice;
        }


    }
}

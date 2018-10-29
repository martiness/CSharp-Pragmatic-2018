namespace HomeWorkObjects
{
    class Car
    {
        private string carBrand;
        private string carModel;
        private double carMileAge;
        private double carPrice;

        public string CarBrand
        {
            get
            {
                return this.carBrand;
            }
            set
            {
                this.carBrand = value;
            }
        }

        public string CarModel
        {
            get
            {
                return this.carModel;
            }
            set
            {
                this.carModel = value;
            }
        }

        //Why this behavior is Not Possible ???
        //public double MileAge(string input)
        //{
        //    get
        //    {
        //        return double.TryParse(input, out mileAge);
        //    }
        //    set
        //    {
        //        this.mileAge = value;
        //    }
        //}

        public double CarMileage
        {
            get
            {
                return this.carMileAge;
            }
            set
            {
                this.carMileAge = value;
            }
        }

        public double CarPrice { get => carPrice; set => carPrice = value; }

        public Car()
        {
            this.carBrand = null;
            this.carModel = null;
            this.carMileAge = 0;
            this.carPrice = 0;
        }

        public Car(string carBrand)
        {
            this.carBrand = carBrand;
            // How to add Car() to initialize other properties???
        }

        public Car(string carBrand, string carModel)
        {
            // How to use Car() to initialize already initialized properties???
            this.carBrand = carBrand;
            this.carModel = carModel;

        }

        public Car(string carBrand, string carModel, double carMileAge)
        {
            this.carBrand = carBrand;
            this.carModel = carModel;
            // Can I add verification for double here: double.TryPrace ???
            this.carMileAge = carMileAge;
        }

        public Car(string carBrand, string carModel, double carMileAge, double carPrice)
        {
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carMileAge = carMileAge;
            this.carPrice = carPrice;
        }


    }
}

namespace BuilderTask
{
    public class Program
    {

        public interface IBuilder
        {
            void Reset();
            void SetSeats(int number);
            void SetEngine(SportEngine engine);
            void SetTripComputer();
            void SetGPS();
        }

        public class Car
        {

        }
        public class Manual { }

        public class SportEngine 
        {
            
        }
        public class CarBuilder : IBuilder
        {
            private Car car;
            public void Reset()
            {
               this.car=new Car();
            }

            public void SetEngine(SportEngine engine)
            {
                Console.WriteLine(engine);
            }

            public void SetGPS()
            {
                Console.WriteLine("GPS set");

            }

            public void SetSeats(int number)
            {
                Console.WriteLine(number);

            }

            public void SetTripComputer()
            {
                Console.WriteLine("Compputer set");
            }
            public Car GetResult()
            {
                return this.car;
            }
        }
        public class CarManualBuilder : IBuilder
        {
            private Manual manual;
            public void Reset()
            {
                this.manual=new Manual();
            }

            public void SetEngine(SportEngine engine)
            {
                Console.WriteLine(engine);
            }

            public void SetGPS()
            {
                Console.WriteLine("GPS set");

            }

            public void SetSeats(int number)
            {
                Console.WriteLine(number);

            }

            public void SetTripComputer()
            {
                Console.WriteLine("Compputer set");
            }
            public Manual GetResult()
            {
                return this.manual;
            }
        }
        public class Director
        {
            public IBuilder builder { get; set; }
            public void MakeSuv(IBuilder? builder)
            {
                builder.Reset();
                builder.SetSeats(4);
                builder.SetEngine(new SportEngine());
                builder.SetTripComputer();
                builder.SetGPS();
            }
            public void MakeSportsCar(IBuilder? builder)
            {
                builder?.Reset();
                builder?.SetSeats(2);
                builder?.SetEngine(new SportEngine());
                builder?.SetTripComputer();
                builder?.SetGPS();
            }
        }

        public class Client
        {
            public Director director { get; set; }

            public Client() {
                CarBuilder builder = new CarBuilder();
                director.MakeSportsCar(builder);
                Car car = builder.GetResult();
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car = new car("brand1", "model1");
            car.mile = 234;
            car.ShowFullInfo();

            Biscycle biscycle = new Biscycle("brand2", "model 2");
            biscycle.mile = 122;
            biscycle.ShowFullInfo();
            
           
        }
    }

    public class vehicle
    {
        public string brand;
        public string model;
        public double mile;

        public vehicle(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
    }

    public class car:vehicle
    {
        public int DoorsNum;



        public car(string brand, string model) : base(brand, model)
        {
            this.brand = brand;
            this.model = model;
        }



      public void ShowFullInfo()
       {
            Console.WriteLine($"brand: {brand}, model: {model} , mile: {mile}");
        }




    }



    


    public class Biscycle:vehicle
    {
        public int WheelNum;

        public Biscycle(string brand,string model):base(brand,model)
        {
            
        }


         public void ShowFullInfo()
         {
            Console.WriteLine($"brand: {brand}, model: {model} , mile: {mile}" );
         }

    }

   
}

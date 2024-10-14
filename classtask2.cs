using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("name1", 3, 4500, 16);
            notebook.Count = 100;
            notebook.Description = "grey";
            notebook.RAM = 16;
            notebook.Sale();
            notebook.ShowFullData();
            //RAM i sala bilmedim :(
        }
    }

  public class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string name,int count,double price)
        {
            Name = name;
            Price = price;
           
        }
    
    public void ShowFullData()
        {
            Console.WriteLine($"name: {Name}, description: {Description}, price: {Price}");
        }
    
    
    }


    public class Notebook:Product 
    {
        public byte RAM;
        public int Storage;
        

        public Notebook(string Name,int Count,double Price,byte RAM):base(Name,Count,Price )
        {
            this.RAM = RAM;
        }

        public void Sale()
         

        {
            if (Count>0)
            {
                Console.WriteLine("mehsul satildi :)");
                Count--;
                
            }
            else
            {
                Console.WriteLine("mehsul yoxdu! :(");
            }
            
        }

    }









}

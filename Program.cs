using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldPopulation
{

    class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(string name, int population)
        {
            Name = name;
            Population = population;



        }

        
        
    }



   
    

     

    class Program
    {
        static void Main(string[] args)
        {
            Country[] countryCollection = { new Country("Afghanistan", 34656032),
                                    new Country("Austria", 8857960),
                                    new Country("Brazil", 210147125),
                                    new Country("Denmark", 5789957),
                                    new Country("Russia", 144526636),
                                    new Country("China", 1403500365),
                                    new Country("Turkey", 80810525),
                                    new Country("Serbia", 7001444),
                                    new Country("Iraq",   37202572),
                                    new Country("San Marino", 33344) };
           

            var StatePopulation = from popul in countryCollection
                                
                                  orderby popul.Population descending
                                  select popul;



            foreach (Country popul in StatePopulation)
            {

               
               
                Console.WriteLine("Country: {0} Population: {1} ",
                    popul.Name, popul.Population);
                Console.WriteLine("press any key to continue ");
                
          

            }

            Console.ReadKey();

           

        }
    }
}

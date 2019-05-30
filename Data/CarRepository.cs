using System.Collections.Generic;
using System.Linq;
using CarApp.Models;

namespace CarApp.Data
{
    public static class CarRepository
    {
        private static List<Cars> _cars = null;

        static CarRepository(){
            _cars = new List<Cars>(){
                new Cars() 
                    {
                        Id=1,
                        Name="1 Series",
                        Description="<p>For Active Users in Urban Life.The BMW 1 Series is a range of subcompact executive cars (C-segment) manufactured by BMW since 2004. It is the successor to the BMW 3 Series Compact and is currently in its second generation.The first generation was produced in hatchback, coupe and convertible body styles. Since the second generation (introduced in 2013), the coupé and convertible models have been marketed as the 2 Series, therefore the 1 Series range no longer includes these body styles. A sedan model became available for the Chinese market in 2017.</p>",
                        ShortDescription="Compact Hatchback",
                        ImageUrl="1.jpg",
                        EngineId=1
                    },
                new Cars() 
                    {
                        Id=2,
                        Name="3 Series",
                        Description="<p>The BMW 3 Series is a compact executive car manufactured by the German automaker BMW since May 1975. It is the successor to the 02 Series and has been produced in seven different generations.The first generation of the 3 Series was only available as a 2-door sedan (saloon), however the model range has since expanded to include a 4-door sedan, 2-door convertible, 2-door coupé, 5-door station wagon, 5-door hatchback and 3-door hatchback body styles. Since 2013, the coupé and convertible models have been marketed as the 4 Series, therefore the 3 Series range no longer includes these body styles.</p>",
                        ShortDescription="Compact Sedan",
                        ImageUrl="3.jpg",
                        EngineId=2
                    },
                new Cars() 
                    {
                        Id=3,
                        Name="4 Series",
                        Description="<p>The BMW F32/F33/F36 series is the first generation of the BMW 4 Series range of compact executive cars. It was launched in 2014 as the successor to the E92/E93 coupé/convertible models of the fifth-generation 3 Series range. The F32/F33/F36 is produced alongside - and shares many features with - the F30 3 Series. The body styles of the range are:As with the F30 3 Series range, the F32/F33/F36 is powered by turbocharged petrol and diesel engines with 3 cylinders (petrol only), 4 cylinders, and 6 cylinders.</p>",
                        ShortDescription="Luxury Sedan",
                        ImageUrl="4.jpg",
                        EngineId=3
                    },
                new Cars() 
                    {
                        Id=4,
                        Name="5 Series",
                        Description="<p>BMW 5 series designed for succes brilliant people. Agressive and comfortable components turbo combined.</p>",
                        ShortDescription="Luxury Coupe",
                        ImageUrl="5.jpg",
                        EngineId=4
                    },
                new Cars() 
                    {
                        Id=5,
                        Name="7 Series",
                        Description="<p>Luxury loumusine for business class. Designed for Downtown persons in lightful highways.</p>",
                        ShortDescription="Premium Sedan",
                        ImageUrl="7.jpg",
                        EngineId=5
                    }
            };
        }
        public static List<Cars> Cars {
            get{
                return _cars;
            }
        }

    public static void AddCar(Cars entity){
        _cars.Add(entity);
    }

    public static Cars GetById(int id){
        return _cars.FirstOrDefault(i=>i.Id == id);
    }


    }
}
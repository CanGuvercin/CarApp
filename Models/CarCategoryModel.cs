using System.Collections.Generic;
namespace CarApp.Models

{
    public class CarCategoryModel
    {
        public Cars Car {get;set;}
        public IEnumerable<Cars> Cars {get;set;}

        public IEnumerable<Category> Categories {get;set;}
    }



}
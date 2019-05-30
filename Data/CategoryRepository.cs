using System.Collections.Generic;
using System.Linq;
using CarApp.Models;

namespace CarApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository(){
            _categories = new List<Category>(){
                new Category(){Id=1, Name="1600 cc Gasoline"},
                new Category(){Id=2, Name="1800 cc Gasoline"},
                new Category(){Id=3, Name="2000 cc Diesel"},
                new Category(){Id=4, Name="2500 cc Diesel"},
                new Category(){Id=5, Name="4000 cc Diesel"},
            };
        }
        public static List<Category> Categories {
            get{
                return _categories;
            }
        }

    public static void AddCategory(Category entity){
        _categories.Add(entity);
    }

    public static Category GetById(int id){
        return _categories.FirstOrDefault(i=>i.Id == id);
    }


    }
}
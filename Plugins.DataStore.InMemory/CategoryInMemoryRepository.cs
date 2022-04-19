﻿using System;
using UseCases.DataStorePluginInterfaces;
using System.Collections.Generic;
using CoreBusiness;
using System.Linq;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository: ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {

            //Add some default categories

            categories = new List<Category>()
            {

               
        
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x=> x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;


            }

            else 
            {

                category.CategoryId = 1;
            
            }
            
           
            
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {

                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;




            }
        
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {

            categories?.Remove(GetCategoryById(categoryId));
        }

        

        
    }
}

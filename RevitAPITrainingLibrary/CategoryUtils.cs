using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class CategoryUtils
    {
        public static List<Category> GetCategories(Document doc)
        {
            var categoryList = new List<Category>();
            Categories categories = doc.Settings.Categories;
            foreach (Category category in categories)
            {
                categoryList.Add(category);
            }
            return categoryList.OrderBy(c => c.Name).ToList();
        }
    }
}

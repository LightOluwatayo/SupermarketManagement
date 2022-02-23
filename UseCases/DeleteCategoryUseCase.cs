using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRespository;

        public DeleteCategoryUseCase(ICategoryRepository categoryRespository)
        {
            this.categoryRespository = categoryRespository;
        }

        public void Delete(int categoryId)
        {
            categoryRespository.DeleteCategory(categoryId);

        }
    }
}

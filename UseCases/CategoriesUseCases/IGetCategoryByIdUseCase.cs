using CoreBusiness;

namespace UseCases
{
    public interface IGetCategoryByIdUseCase
    {
        Product Execute(int categoryId);
       // Product Execute(int categoryId);
    }
}
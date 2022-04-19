using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace UseCases
{
  public   class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetCategoryByIdUseCase getProductByIdUseCase;

        public RecordTransactionUseCase(ITransactionRepository transactionRepository,
            IGetCategoryByIdUseCase getProductByIdUseCase)
        {
            this.transactionRepository = transactionRepository;
            this.getProductByIdUseCase = getProductByIdUseCase;
        }

        public void Execute(string cashierName, int productId,int qty)
        {
            var product = getProductByIdUseCase.Execute(productId);

            transactionRepository.Save( cashierName, productId, product.Name, product.Price.Value, product.Quantity.Value, qty);
        }
    }
}

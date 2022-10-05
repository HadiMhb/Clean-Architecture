using dddPrg.Domain.CommandResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Commands
{
    public class AddProductCommand:IRequest<AddProductResult>
    {
        public string Title { get; private set; }
        public string Body { get; private set; }
        public decimal Price { get; private set; }
        public string ImagePath { get; private set; }
        public string FilePath { get; private set; }
        public short ProductCategoryId { get; private set; }
        public bool IsVisible { get; private set; }
        public bool IsDeleted { get; private set; }
        public bool IsSellable { get; private set; }
    }
}

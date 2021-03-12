using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get;}
        IOrderRepository OrderRepository { get; }
        ICourierRepository CourierRepository { get; }
        IOrderShippingDetails OrderShippingDetails { get; }

        void save();

        Task<int> SaveAsync();
    }
}

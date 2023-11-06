﻿namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
	{
		ICategoryRepository Category { get; }

		ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

		ICompanyRepository Company { get; }

        IShoppingCartRepository ShoppingCart { get; }

        IApplicationUserRepository ApplicationUser { get; }

        IOrderDetailsRepository OrderDetails { get; }

        IOrderHeaderRepository OrderHeader { get; }

        void Save();
	}
}


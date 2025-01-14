﻿using System.Collections.Generic;
using _01_LampShadeQuery.Contract.Product;
using ShopManagement.Application.Contracts.Order;

namespace _01_LampshadeQuery.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetProductDetails(string slug);
        List<ProductQueryModel> GetLatestArrivals();
        List<ProductQueryModel> Search(string value);
        List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);

    }
}

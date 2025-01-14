﻿using _0_Framework.Domain;
using System.Collections.Generic;
using DiscountManagement.Application.Contract.CustomerDiscount;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public interface ICustomerDiscountRepository : IRepository<long, CustomerDiscount>
    {
        EditCustoemrDiscount GetDetails(long id);
       
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}

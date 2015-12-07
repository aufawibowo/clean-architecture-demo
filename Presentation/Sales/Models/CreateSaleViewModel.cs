﻿using System.Collections.Generic;
using System.Web.Mvc;
using CleanArchitecture.Application.Customers.Queries.GetCustomerList;
using CleanArchitecture.Application.Employees.Queries.GetEmployeesList;
using CleanArchitecture.Application.Products.Queries.GetProductsList;
using CleanArchitecture.Application.Sales.Commands.CreateSale;

namespace CleanArchitecture.Presentation.Sales.Models
{
    public class CreateSaleViewModel
    {
        public List<SelectListItem> Customers { get; set; }

        public List<SelectListItem> Employees { get; set; }

        public List<SelectListItem> Products { get; set; }

        public CreateSaleModel Sale { get; set; }
    }
}
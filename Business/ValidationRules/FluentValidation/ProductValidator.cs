using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();//ProductName boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2);//ProductName minimum karakter 2 harf olmalı
            RuleFor(p => p.UnitPrice).NotEmpty();//UnitPrice boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWİthA).WithMessage("Ürünler A harfi ile başlamalı...");//Sadece A harfi ile başlayanlar
        }

        private bool StartWİthA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

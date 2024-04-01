using System;
using System.Collections.Generic;

namespace Week10.lab.N01617780.Models.Entities;

public partial class OrderOption
{
    public decimal SalesTaxRate { get; set; }

    public decimal FirstBookShipCharge { get; set; }

    public decimal AdditionalBookShipCharge { get; set; }
}

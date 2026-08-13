using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.DTOs.Orders
{
    public class CreateOrderDto
    {
        public Guid ShippingAddressId { get; set; }
    }
}

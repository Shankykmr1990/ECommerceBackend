using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.DTOs.Orders
{
    public class OrderItemDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

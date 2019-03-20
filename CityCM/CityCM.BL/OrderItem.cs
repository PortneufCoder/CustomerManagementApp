using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; } // the ? mark on the data types means its a nullable type or it can be 0
        public int Quantity { get; set; }

        // Retrieve one orderItem
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0)
                isValid = false;
            if (ProductId <= 0)
                isValid = false;
            if (PurchasePrice == null)
                isValid = false;

            return isValid;
                    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class OrderRepository:IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShoppingCart shoppingCart;
        
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            this.appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = shoppingCart.ShoppingCartItems;
            order.OrderTotal = shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    VinylId = shoppingCartItem.Vinyl.VinylId,
                    Price = shoppingCartItem.Vinyl.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            appDbContext.Orders.Add(order);

            appDbContext.SaveChanges();
        }





    }
}

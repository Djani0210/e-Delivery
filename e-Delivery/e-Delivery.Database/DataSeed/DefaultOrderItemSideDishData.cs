using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{

    public static class DefaultOrderItemSideDishData
    {
        public static IEnumerable<OrderItemSideDish> OrderItemSideDishes
        {
            get => new List<OrderItemSideDish>
            {
                new OrderItemSideDish
                {
                    OrderItemId = 1,
                    SideDishId = 1
                },
                new OrderItemSideDish
                {
                    OrderItemId = 2,
                    SideDishId = 2
                },
                new OrderItemSideDish
                {
                    OrderItemId = 3,
                    SideDishId = 1
                }, new OrderItemSideDish
                {
                    OrderItemId = 4,
                    SideDishId = 1
                },
                new OrderItemSideDish
                {
                    OrderItemId = 5,
                    SideDishId = 2
                },
                new OrderItemSideDish
                {
                    OrderItemId = 6,
                    SideDishId = 4
                }, new OrderItemSideDish
                {
                    OrderItemId = 7,
                    SideDishId = 4
                },
                new OrderItemSideDish
                {
                    OrderItemId = 8,
                    SideDishId = 2
                },
                new OrderItemSideDish
                {
                    OrderItemId = 9,
                    SideDishId = 1
                },
                new OrderItemSideDish
                {
                    OrderItemId = 10,
                    SideDishId = 1
                },
              



            };
        }
    }

}

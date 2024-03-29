﻿using price.Models;
using System;
using System.Collections.Generic;

namespace price.Helpers
{
    public static class BookPriceFactoryHelper
    {
        public static List<BookPrice> GenerateBookPrices()
        {
            return new List<BookPrice>
            {
                new BookPrice
                {
                    Code = Guid.Parse("3872339b-5556-4c94-b7ca-2cc8abde32d8"),
                    Price = 1000.93m
                },
                new BookPrice
                {
                    Code = Guid.Parse("6ef14d71-cd31-4c94-b88d-9d2dc26e3fb1"),
                    Price = 2000.90m
                },
                new BookPrice
                {
                    Code = Guid.Parse("24eca492-67f3-4dac-a66e-1643bc6766e8"),
                    Price = 3000.85m
                },
                new BookPrice
                {
                    Code = Guid.Parse("2307feb3-d6e2-4758-968f-069833510018"),
                    Price = 4000.02m
                },
                new BookPrice
                {
                    Code = Guid.Parse("22d1e9b8-af4e-4859-a55b-5c6fd573736a"),
                    Price = 5000.93m
                }
            };
        }
    }
}

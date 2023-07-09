using System;
using Azure;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;

namespace BlazingShop.Server.Services.PaymentService
{
	public class PaymentService : IPaymentService
	{
		public PaymentService()
		{
            StripeConfiguration.ApiKey = "sk_test_51NS2DTKD335WOnoaF7vs2WjQptVJylSdQnaiU0bmIID5mI6PJS7zCmLRE2Ugoxoh4o810QKL8qMKnGhfsbAINney002Y44gEEH";
        }

        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image }
                    }
                },
                Quantity = ci.Quantity
            }));

            var options = new SessionCreateOptions
            {
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "http://localhost:5065/order-success",
                CancelUrl = "http://localhost:5065/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return session;
        }
    }
}


﻿using e_Delivery.Model.Stripe;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;

namespace e_Delivery.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {

        private readonly string stripeSecretKey;

        public PaymentController(IConfiguration configuration)
        {
            stripeSecretKey = configuration.GetSection("StripeApiSecretKey").Value;
        }

        [HttpPost]
        public IActionResult ProcessPayment([FromBody] PaymentRequestVM paymentRequest)
        {
            StripeConfiguration.ApiKey = stripeSecretKey;

            try
            {
                var service = new PaymentIntentService();
                var createOptions = new PaymentIntentCreateOptions
                {
                    PaymentMethod = paymentRequest.PaymentMethodId,
                    Amount = paymentRequest.Amount,
                    Currency = "bam",
                    ConfirmationMethod = "manual",
                    Confirm = true
                };
                var paymentIntent = service.Create(createOptions);

                var charge_id = paymentIntent.LatestChargeId;

                return Ok(new { paymentIntentId = paymentIntent.Id, charge_id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpPost("create-customer")]
        public IActionResult CreateCustomer([FromBody] PaymentMethodRequestVM requestDto)
        {
            StripeConfiguration.ApiKey = stripeSecretKey;

            try
            {
                var options = new CustomerCreateOptions
                {
                    PaymentMethod = requestDto.PaymentMethodId,
                    InvoiceSettings = new CustomerInvoiceSettingsOptions
                    {
                        DefaultPaymentMethod = requestDto.PaymentMethodId
                    }
                };

                var service = new CustomerService();
                var customer = service.Create(options);

                return Ok(new { customerId = customer.Id });
            }
            catch (StripeException e)
            {
                return BadRequest(new { error = e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { error = e.Message });
            }
        }

        

        [HttpPost("refund")]
        public IActionResult RefundPayment([FromBody] RefundRequestVM refundRequest)
        {
            StripeConfiguration.ApiKey = stripeSecretKey;

            try
            {
                var service = new RefundService();
                var refundOptions = new RefundCreateOptions
                {
                    PaymentIntent = refundRequest.paymentIntentId
                };
                var refund = service.Create(refundOptions);


                return Ok(new { refundId = refund.Id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpGet("receipt/{chargeId}")]
        public IActionResult GetReceiptUrl(string chargeId)
        {
            StripeConfiguration.ApiKey = stripeSecretKey;

            try
            {
                var service = new ChargeService();
                var charge = service.Get(chargeId);

                var receiptUrl = charge.ReceiptUrl;

                return Ok(new { receiptUrl });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

    }

}

﻿using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Checkout
{
    public partial class CheckoutCompletedModel : BaseNopModel
    {
        public int OrderId { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }
        public bool Confident { get; set; }
        public string ConfidentMessage { get; set; }
    }
}
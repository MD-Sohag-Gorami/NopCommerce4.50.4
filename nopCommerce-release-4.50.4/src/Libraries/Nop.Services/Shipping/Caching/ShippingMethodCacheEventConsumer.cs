﻿using Nop.Core.Domain.Shipping;
using Nop.Services.Caching;
using System.Threading.Tasks;

namespace Nop.Services.Shipping.Caching
{
    /// <summary>
    /// Represents a shipping method cache event consumer
    /// </summary>
    public partial class ShippingMethodCacheEventConsumer : CacheEventConsumer<ShippingMethod>
    {
    }
}

﻿namespace Catalog.Products.Events;
public record class ProductPriceChangedEvent(Product product)
    :IDomainEvent;


﻿using Weapsy.Framework.Domain;

namespace Weapsy.Domain.Sites.Events
{
    public class SiteReopened : DomainEvent
    {
        public string Name { get; set; }
    }
}
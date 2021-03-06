﻿using AllReady.Areas.Admin.ViewModels.Shared;
using MediatR;

namespace AllReady.Areas.Admin.Features.Events
{
    public class EventSummaryQuery : IAsyncRequest<EventSummaryViewModel>
    {
        public int EventId { get; set; }
    }
}

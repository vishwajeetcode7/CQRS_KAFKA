using CQRS.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.common.Events
{
    public class MessageUpdatedEvent: BaseEvent
    {
        public MessageUpdatedEvent(): base(nameof(MessageUpdatedEvent))
        {     
        }

        public string Message { get; set; }
    }

}

using CQRS.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.common.Events
{
    public class CommentRemovedEvent: BaseEvent
    {
        public CommentRemovedEvent(): base(nameof(CommentRemovedEvent))
        {
        }
        public Guid CommentId { get; set; }
    }
}

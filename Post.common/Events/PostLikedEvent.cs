using CQRS.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post.common.Events
{
    public class PostLikedEvent: BaseEvent
    {
        public PostLikedEvent() : base(nameof(PostLikedEvent))
        {
        }
    }
}

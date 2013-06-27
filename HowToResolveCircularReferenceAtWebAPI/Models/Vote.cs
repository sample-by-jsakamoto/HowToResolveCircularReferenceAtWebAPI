using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HowToResolveCircularReferenceAtWebAPI.Models
{
    public class Vote
    {
        public Guid VoteId { get; set; }

        public Guid ThemeId { get; set; }

        public Theme Theme { get; set; }

        public Vote(Theme theme)
        {
            this.VoteId = Guid.NewGuid();
            this.Theme = theme;
        }
    }
}
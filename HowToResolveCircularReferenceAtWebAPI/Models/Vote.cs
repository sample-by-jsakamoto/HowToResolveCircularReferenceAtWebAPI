using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace HowToResolveCircularReferenceAtWebAPI.Models
{
    [DataContract]
    public class Vote
    {
        [DataMember]
        public Guid VoteId { get; set; }

        [DataMember]
        public Guid ThemeId { get; set; }

        public Theme Theme { get; set; }

        public Vote(Theme theme)
        {
            this.VoteId = Guid.NewGuid();
            this.Theme = theme;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HowToResolveCircularReferenceAtWebAPI.Models
{
    public class Theme
    {
        public Guid ThemeId { get; set; }

        public List<Vote> Votes { get; set; }

        public Theme()
        {
            this.ThemeId = Guid.NewGuid();
            this.Votes = new List<Vote>();
        }
    }
}
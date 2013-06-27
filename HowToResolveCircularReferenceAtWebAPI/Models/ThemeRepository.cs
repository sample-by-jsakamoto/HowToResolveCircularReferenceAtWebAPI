using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HowToResolveCircularReferenceAtWebAPI.Models
{
    public class ThemeRepository
    {
        public IEnumerable<Theme> GetAllThemes()
        {
            var themes = new[] { new Theme(), new Theme() };
            foreach (var theme in themes)
            {
                theme.Votes.AddRange(Enumerable.Range(0, 2).Select(_ => new Vote(theme)));
            }

            return themes;
        }
    }
}
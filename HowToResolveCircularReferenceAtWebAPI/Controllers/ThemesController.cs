using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HowToResolveCircularReferenceAtWebAPI.Models;

namespace HowToResolveCircularReferenceAtWebAPI.Controllers
{
    public class ThemesController : ApiController
    {
        public ThemeRepository Repository { get; set; }

        public ThemesController()
        {
            this.Repository = new ThemeRepository();
        }

        // GET api/themes
        public IEnumerable<Theme> Get()
        {
            return this.Repository.GetAllThemes();
        }
    }
}
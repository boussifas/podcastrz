using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Podcastrz.Models;
using Podcastrz.Data;

using System.Diagnostics;

using Microsoft.AspNetCore.Http;

namespace Podcastrz.Controllers
{
    [Authorize]
    public class PodcastController : Controller
    {
        private readonly ILogger<PodcastController> _logger;
        private readonly PodcastrzContext _context;

        public PodcastController(ILogger<PodcastController> logger, PodcastrzContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }

    
}
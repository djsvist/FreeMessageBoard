using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMB.Services.Posts;

#nullable disable

namespace FMB.Core.API.Models
{
    public class CreatePostRequest
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
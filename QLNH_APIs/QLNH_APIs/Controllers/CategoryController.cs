﻿using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Category.ToList();
        }
    }
}

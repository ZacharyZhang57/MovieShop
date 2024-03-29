﻿using ApplicationCore.ServiesContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet]
        [Route("Genres")]
        public async Task<IActionResult> GetAllGenres() 
        {
            var genres = await _genreService.GetAllGenres();
            return Ok(genres);
        }
	}
}

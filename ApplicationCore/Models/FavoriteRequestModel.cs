﻿using ApplicationCore.Entities;

namespace ApplicationCore.Models
{
    public class FavoriteRequestModel
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public Movie movie { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Genre : Entity
    {
        public string name { get; set; }

        public List<MovieGenre> MovieGenres { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;

namespace Fanime.Domain.Entities
{
    public class Anime
    {
        public int Id { get; set; }

        
        public string Title { get; set; } // English / Common Name?

        public string Kanji { get; set; } // Japanese Kanji

        public string Romanji { get; set; } // Japanese Romanji

        public string Synonyms { get; set; }

        public string Summary { get; set; }

        public AnimeType Type { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<Episode> Episodes { get; set; }

    }

    public enum AnimeType
    {
        TV = 0,
        Short = 1,
        Movie = 2
    }
}
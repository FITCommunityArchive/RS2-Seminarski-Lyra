﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class AlbumUpsertRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        public byte[] Image { get; set; }
        public int ArtistID { get; set; }
        public List<int> Tracks { get; set; } = new List<int>();
        public List<int> TracksToDelete { get; set; } = new List<int>();

    }
}

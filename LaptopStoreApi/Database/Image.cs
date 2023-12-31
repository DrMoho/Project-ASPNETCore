﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LaptopStoreApi.Database
{
    [Table("Images")]
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        public int LaptopStatusId { get; set; }
        public LaptopStatus? LaptopStatus { get; set; }
    }
}

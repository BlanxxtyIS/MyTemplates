﻿namespace Blazor_test
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string AuthorName { get; set; } = "";
        public int TimeInMinutes { get; set; }
        public string TimeFormatted => $"{TimeInMinutes / 60}h {TimeInMinutes % 60}m";
        public int Rating { get; set; }
        public byte[] ImageData { get; set; } = Array.Empty<byte>();

        public string ImageType { get; set; } = "";

        public string ImageBase64 => ImageData != null && ImageData.Length > 0
            ? $"data:{ImageType};base64,{Convert.ToBase64String(ImageData)}"
            : "";
        public List<string> Roles { get; set; } = new List<String>();
    }
}

namespace Models
{
    public class NewsItemInputModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string ImgSource { get; set; }
        [Required]
        [Range(0-50)]
        public string ShortDescription{ get; set; }
        [MinLength(50)]
        [MaxLength(225)]
        public string LongDescription{ get; set; }
        [Required]
        public DateTime PublishDate{get; set;}
    }
}
namespace Models
{
    public class AuthorInputModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImgSource { get; set; }
        [MaxLength(225)]
        public string Bio{ get; set; }
    }
}
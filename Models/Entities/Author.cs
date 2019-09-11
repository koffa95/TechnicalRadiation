using System;

namespace Models.Entities
{
    public class Author
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string ProfileImgSource { get; set;}
        public string Bio { get; set;}
        private DateTime ModifiedBy { get; set;} //(code-generated),
        private DateTime CreatedDate { get; set;}//(code-generated),
        private DateTime ModifiedDate { get; set;}//(code-generated)
    }
}
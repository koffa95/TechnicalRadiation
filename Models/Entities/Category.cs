using System;

namespace Models.Entities
{
    public class Category
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Slug { get; set;} //string??????????
        public string ModifiedBy { get; set;} //(code-generated),
        public DateTime CreatedDate { get; set;}//(code-generated),
        public DateTime ModifiedDate { get; set;}//(code-generated)
    }
}

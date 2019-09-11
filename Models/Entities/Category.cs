namespace Models.Entities
{
    public class Category
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Slug { get; set;} //string??????????
        private DateTime ModifiedBy { get; set;} //(code-generated),
        private DateTime CreatedDate { get; set;}//(code-generated),
        private DateTime ModifiedDate { get; set;}//(code-generated)
    }
}

namespace BigSchool.Models
{
    public interface IColletion<T>
    {
        ApplicationUser Follower { get; set; }
    }
}
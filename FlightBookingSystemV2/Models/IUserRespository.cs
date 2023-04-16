namespace FlightBookingSystemV2.Models
{
    public interface IUserRespository
    {
        public User Get(int id);
        public List<User> GetAll();
        public User Delete(int id);
        public void Add(User user);
        public User Update(int id, User user);
    }
}

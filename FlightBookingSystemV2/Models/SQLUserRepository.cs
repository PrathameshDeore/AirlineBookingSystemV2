using FlightBookingSystemV2.Data;

namespace FlightBookingSystemV2.Models
{
    public class SQLUserRepository:IUserRespository
    {
        private readonly FlightContext _context;
        public SQLUserRepository(FlightContext context)
        {
            this._context = context;
        }
        public User Get(int id)
        {
            return (_context.Users.FirstOrDefault(u => u.UserId == id));
        }
        public List<User> GetAll()
        {
            return(_context.Users.ToList());
        }
        public User Delete(int id)
        {
            User user = _context.Users.FirstOrDefault(u=>u.UserId==id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return user;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User Update(int id, User user)
        {
            User userG = _context.Users.FirstOrDefault();
            if(userG != null)
            {
                userG = user;
                _context.SaveChanges();
            }
            return userG;
        }
    }
}

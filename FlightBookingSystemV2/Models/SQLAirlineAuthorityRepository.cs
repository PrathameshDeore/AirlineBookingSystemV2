using FlightBookingSystemV2.Data;

namespace FlightBookingSystemV2.Models
{
    public class SQLAirlineAuthorityRepository:IAirlineAuthorityRepository
    {
        private readonly FlightContext _context;
        public SQLAirlineAuthorityRepository(FlightContext context)
        {
            this._context = context;
        }
        public AirlineAuthority Get(string name)
        {
            return (_context.AirlineAuthorities.FirstOrDefault(u => u.AirlineName == name));
        }
        public List<AirlineAuthority> GetAll()
        {
            return (_context.AirlineAuthorities.ToList());
        }
        public AirlineAuthority Delete(string name)
        {
            AirlineAuthority airlineAuthority = _context.AirlineAuthorities.FirstOrDefault(u => u.AirlineName == name);
            if (airlineAuthority != null)
            {
                _context.AirlineAuthorities.Remove(airlineAuthority);
                _context.SaveChanges();
            }
            return airlineAuthority;
        }
        public void Add(AirlineAuthority airlineAuthority)
        {
            _context.AirlineAuthorities.Add(airlineAuthority);
            _context.SaveChanges();
        }
        public AirlineAuthority Update(string name, AirlineAuthority airlineAuthority)
        {
            AirlineAuthority airlineAuthorityG = _context.AirlineAuthorities.FirstOrDefault();
            if (airlineAuthorityG != null)
            {
                airlineAuthorityG = airlineAuthority;
                _context.SaveChanges();
            }
            return airlineAuthorityG;
        }
    }
}

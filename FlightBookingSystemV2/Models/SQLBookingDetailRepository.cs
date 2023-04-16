using FlightBookingSystemV2.Data;

namespace FlightBookingSystemV2.Models
{
    public class SQLBookingDetailRepository:IBookingDetailRepository
    {
        private readonly FlightContext _context;
        public SQLBookingDetailRepository(FlightContext context)
        {
            this._context = context;
        }
        public BookingDetail Get(int id)
        {
            return (_context.BookingDetails.FirstOrDefault(u => u.BookingId == id));
        }
        public List<BookingDetail> GetAll()
        {
            return (_context.BookingDetails.ToList());
        }
        public BookingDetail Delete(int id)
        {
            BookingDetail bookingDetail = _context.BookingDetails.FirstOrDefault(u => u.BookingId == id);
            if (bookingDetail != null)
            {
                _context.BookingDetails.Remove(bookingDetail);
                _context.SaveChanges();
            }
            return bookingDetail;
        }
        public void Add(BookingDetail bookingDetail)
        {
            _context.BookingDetails.Add(bookingDetail);
            _context.SaveChanges();
        }
        public BookingDetail Update(int id, BookingDetail bookingDetail)
        {
            BookingDetail bookingDetailG = _context.BookingDetails.FirstOrDefault();
            if (bookingDetailG != null)
            {
                bookingDetailG = bookingDetail;
                _context.SaveChanges();
            }
            return bookingDetailG;
        }
    }
}

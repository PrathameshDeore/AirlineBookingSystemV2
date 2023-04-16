﻿namespace FlightBookingSystemV2.Models
{
    public interface IJourneyDetailRepository
    {
        public JourneyDetail Get(int id);
        public List<JourneyDetail> GetAll();
        public JourneyDetail Delete(int id);
        public void Add(JourneyDetail journeyDetail);
        public JourneyDetail Update(int id, JourneyDetail journeyDetail);
    }
}

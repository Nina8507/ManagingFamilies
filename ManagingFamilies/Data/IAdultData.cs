using System.Collections.Generic;
using ManagingFamilies.Models;

namespace ManagingFamilies.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAllAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        Adult GetAdult(int id);
        void Update(Adult adult);
    }
}
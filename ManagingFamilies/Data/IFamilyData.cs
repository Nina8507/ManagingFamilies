using System.Collections.Generic;
using ManagingFamilies.Models;

namespace ManagingFamilies.Data
{
    public interface IFamilyData
    {
        IList<Family> GetAllFamilies();
        void AddFamily(Family family);
        void RemoveFamily(Family family);
       
    }
}
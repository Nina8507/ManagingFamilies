using System.Collections.Generic;
using System.Linq;
using ManagingFamilies.Models;
using ManagingFamilies.Persistance;

namespace ManagingFamilies.Data
{
    public class FamilyData:IFamilyData
    {
        private FileContext fileContext;
        private List<Family> families;

        public FamilyData()
        {
            fileContext = new FileContext();
            families = new List<Family>();
        }
        
        public IList<Family> GetAllFamilies()
        {
            return fileContext.Families;
        }

        public void AddFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Family family)
        {
            throw new System.NotImplementedException();
        }
    }
}
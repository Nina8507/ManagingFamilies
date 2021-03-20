using System.Collections.Generic;
using System.Linq;
using ManagingFamilies.Models;
using ManagingFamilies.Persistance;

namespace ManagingFamilies.Data
{
    public class AdultData : IAdultData
    {
        private FileContext fileContext;
        private IList<Adult> adults;
        
        public AdultData(FileContext fileContext)
        {
            this.fileContext = fileContext;
           adults = fileContext.Adults;
        }
        public IList<Adult> GetAllAdults()
        {
            return fileContext.Adults;
        }

        public void AddAdult(Adult adult)
        {
            /*int max = 0;
            if (adults.Count == 0)
            {
                adults.Add(new Adult()
                {
                    Id = adult.Id, 
                    FirstName = adult.FirstName,
                    LastName =  adult.LastName,
                    HairColor = adult.HairColor,
                    Age = adult.Age,
                    Weight = adult.Weight,
                    Height = adult.Height,
                    Sex = adult.Sex,
                    JobTitle = adult.JobTitle
                });
            }*/
            
            adults.Add(adult);
            fileContext.SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            Adult adultToRemove = adults.First(a => a.Id == adultId);
            adults.Remove(adultToRemove);
            fileContext.SaveChanges();
        }

        public Adult GetAdult(int id)
        {
            Adult adultToEdit = adults.First(a => a.Id == id);
            return adultToEdit;
        }

        public void Update(Adult adult)
        {
            Adult adultToUpdate = fileContext.Adults.First(a => a.Id == adult.Id);
            adults.Remove(adultToUpdate);
            adults.Add(adultToUpdate);
            fileContext.SaveChanges();
        }
    }
}
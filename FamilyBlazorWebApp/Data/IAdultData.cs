using System.Collections.Generic;
using Models;

namespace Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        void UpdateAdult(Adult adult);
        Adult Get(int adultId);
    }
}
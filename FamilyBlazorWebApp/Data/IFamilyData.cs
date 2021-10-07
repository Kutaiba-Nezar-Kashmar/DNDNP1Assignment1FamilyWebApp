﻿using System.Collections.Generic;
using Models;

namespace Data
{
    public interface IFamilyData
    {
        IList<Family> GetFamilies();
        void AddFamily(Family family);
        void RemoveFamily(int familyId);
        void UpdateFamily(Family family);
        Family Get(int familyId);
    }
}
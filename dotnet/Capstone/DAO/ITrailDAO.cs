using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface ITrailDAO
    {
        public List<Trail> GetAllTrails();
        public Trail GetTrailByTrailID(int trailID);

        public List<Trail> GetTrailsByUserID(int userID);
    }
}

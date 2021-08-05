using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Interface
{
    public interface IPostable
    {
        void Post(string entry);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Interface
{
    public interface ICommentable
    {
        void Comment(IItem target, string text);
    }
}

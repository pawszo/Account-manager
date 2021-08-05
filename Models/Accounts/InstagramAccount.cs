using AccountMaker.Models.Abstract;
using AccountMaker.Models.Actions;
using AccountMaker.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountMaker.Models.Accounts
{
    public class InstagramAccount : AccountBase, IPostable, ICommentable, ILikable, ISubscribable
    {

        public void Comment(IItem target, string text)
        {
            var settings = new Dictionary<string, string>();
            settings.Add("comment", text);
            var action = new InstagramCommentAction(target, settings);
            PendingActions.Enqueue(action);
        }

        public void Like(IItem target)
        {
            throw new NotImplementedException();
        }

        public void Post(string entry)
        {
            throw new NotImplementedException();
        }

        public void Subscribe(IItem target)
        {
            var settings = new Dictionary<string, string>();
            var action = new InstagramSubscribeAction(target, settings);
            PendingActions.Enqueue(action);
        }
    }
}

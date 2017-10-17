using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spor.Core;

namespace Spor.Class
{
    public class People
    {
         IPlay _play;

        public People(IPlay play)
        {
            _play = play;
        }

        public string Category()
        {
            return _play.Play();
        }

    }
}
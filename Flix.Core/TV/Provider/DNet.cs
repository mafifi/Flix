using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Flix.Core.TV.Provider
{
    public class DNet : IChannelProvider
    {
        public DNet()
        {
            
        }

        public IList<Channel> Channels
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
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
using Java.Security;

namespace Flix.Core.TV.Provider
{
    public interface IChannelProvider
    {
        IList<Channel> Channels { get; }
    }
}
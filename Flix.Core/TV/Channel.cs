using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Flix.Core.TV
{
    public class Channel
    {
        public int Number { get; private set; }

        public Icon Icon { get; private set; }

        public string ShortDescription { get; private set; }

        public string Title { get; private set; }

        public byte[] Logo { get; private set; }

        public Channel(int number, Icon icon, string shortDescription, string title, Uri logoUri)
        {
            
        }
    }
}
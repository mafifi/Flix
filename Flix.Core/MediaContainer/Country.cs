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

namespace Flix.Core.MediaContainer
{
    public class Country
    {
        /// <summary>
        /// Creates a country object
        /// </summary>
        /// <param name="tag"></param>
        public Country(string tag)
        {
            Tag = tag;
        }

        /// <summary>
        /// The unique id of this country
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The country's name
        /// </summary>
        public string Tag { get; private set; }
    }
}
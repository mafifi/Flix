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
using Java.Net;

namespace Flix.Core.MediaContainer
{
    public class Role
    {
        /// <summary>
        /// Creates a new role object to be used in videos
        /// </summary>
        /// <param name="id">Unique identity of the role</param>
        /// <param name="tag">The actor or artist's full name</param>
        /// <param name="role">The name of the character played by the actor or artist</param>
        /// <param name="thumb">An optional URL to a thumbnail picture of this particular role</param>
        public Role(int id, string tag, string role, string thumb = null)
        {
            Id = id;
            Tag = tag;
            RoleName = role;
            if (thumb == null)
            {
                Thumb = null;
            }
            else
            {
                Thumb = new URL(thumb);
            }
        }

        /// <summary>
        /// The unique id for this role
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// The actor's name
        /// </summary>
        public string Tag { get; private set; }

        /// <summary>
        /// The character's name played by the actor
        /// </summary>
        public string RoleName { get; private set; }

        /// <summary>
        /// Optional url thumbnail for this role
        /// </summary>
        public URL Thumb { get; private set; }
    }
}
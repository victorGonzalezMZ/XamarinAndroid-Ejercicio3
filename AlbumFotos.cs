using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3Cards
{
    public class AlbumFotos
    {
        public Fotografias[] Fotos;

        public AlbumFotos()
        {
            Fotos = ConjuntodeFotos;
        }

        public int CantidaddeFotos
        {
            get { return Fotos.Length; }
        }

        public Fotografias this[int i]
        {
            get { return Fotos[i]; }
        }

        static Fotografias[] ConjuntodeFotos =
        {
            new Fotografias { mFotoID = Resource.Drawable.uno, mTextoFoto = "Carro" },

            new Fotografias { mFotoID = Resource.Drawable.dos, mTextoFoto = "Dados" },

            new Fotografias { mFotoID = Resource.Drawable.tres, mTextoFoto = "Guantes" },

            new Fotografias { mFotoID = Resource.Drawable.cuatro, mTextoFoto = "Nintendo" },

            new Fotografias { mFotoID = Resource.Drawable.cinco, mTextoFoto = "Sword"}
        };
    }
}
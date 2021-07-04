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
    public class Fotografias
    {
        public int mFotoID;
        public string mTextoFoto;
        public int FotoID { get { return mFotoID; } }
        public string TextoFoto { get { return mTextoFoto; } }
    }
}
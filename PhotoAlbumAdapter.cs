using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3Cards
{
    public class PhotoAlbumAdapter: RecyclerView.Adapter
    {
        public event EventHandler<int> seleccionElemento;
        public AlbumFotos mAlbumFotos;

        public PhotoAlbumAdapter(AlbumFotos AlbumFotos)
        {
            mAlbumFotos = AlbumFotos;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup Contenido, int viewType)
        {
            View VistadeElemento = LayoutInflater.From(Contenido.Context).
                        Inflate(Resource.Layout.PhotoCardView, Contenido, false);
            PhotoViewHolder pvh = new PhotoViewHolder(VistadeElemento, OnClick);
            return pvh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder cabecera, int posicion)
        {
            PhotoViewHolder pvh = cabecera as PhotoViewHolder;
            pvh.Imagen.SetImageResource(mAlbumFotos[posicion].FotoID);
            pvh.Texto.Text = mAlbumFotos[posicion].TextoFoto;
        }

        public override int ItemCount
        {
            get { return mAlbumFotos.CantidaddeFotos; }
        }

        void OnClick(int position)
        {
            seleccionElemento(this, position);
        }
    }

    public class PhotoViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Imagen { get; private set; }
        public TextView Texto { get; private set; }

        public PhotoViewHolder(View Elemento, Action<int> Colocador) : base(Elemento)
        {
            Imagen = Elemento.FindViewById<ImageView>(Resource.Id.imagen);
            Texto = Elemento.FindViewById<TextView>(Resource.Id.texto);
            Elemento.Click += (sender, e) => Colocador(base.LayoutPosition);
        }
    }
}
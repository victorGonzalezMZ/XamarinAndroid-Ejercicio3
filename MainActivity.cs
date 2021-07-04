using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Ejercicio3Cards
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView RecicladordeVista;
        RecyclerView.LayoutManager AdministradorInterfaz;
        PhotoAlbumAdapter Adaptador;
        AlbumFotos mAlbumFotos;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mAlbumFotos = new AlbumFotos();
            RecicladordeVista = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            //AdministradorInterfaz = new LinearLayoutManager(this);
            RecicladordeVista.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
            Adaptador = new PhotoAlbumAdapter(mAlbumFotos);
            Adaptador.seleccionElemento += OnItemClick;
            RecicladordeVista.SetAdapter(Adaptador);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        void OnItemClick(object sender, int posicion)
        {
            int NumerodeFoto = posicion + 1;
            Toast.MakeText(this, "Fotografía" + NumerodeFoto, ToastLength.Long).Show();
        }
    }
}
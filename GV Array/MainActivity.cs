using Android.App;
using Android.OS;
using Android.Widget;


namespace GV_Array
{
    [Activity(Label = "GridView Array", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       //DECLARATIONS
        private GridView gv;
        private ArrayAdapter<string> adapter;
        private readonly string[] spacecrafts = {"Columbia","Challenger","Spitzer","Kepler","Casini","Voyager","Pioneer","Enterprise","Rosetter"}; 


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //REFERENCES
            gv = FindViewById<GridView>(Resource.Id.gv);

            //ADAPTER
            adapter=new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,spacecrafts);
            gv.Adapter = adapter;

            //ITEMC CLICKS
            gv.ItemClick += Gv_ItemClick;

        }

        private void Gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //SHOW MSG
            Toast.MakeText(this, adapter.GetItem(e.Position), ToastLength.Short).Show();
        }
    }
}


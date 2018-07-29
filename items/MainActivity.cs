using Android.App;
using Android.Widget;
using Android.OS;

namespace items
{
    [Activity(Label = "items", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView myList;  

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            myList = FindViewById<ListView>(Resource.Id.listView); 

            myList.Adapter = new MyCustomListAdapter(UserData.Users, this);
        }
    }
}


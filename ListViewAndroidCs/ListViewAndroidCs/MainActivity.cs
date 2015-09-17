using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewAndroidCs
{
    [Activity(Label = "ListViewAndroidCs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> Items;
        private ListView myListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            myListView = FindViewById<ListView>(Resource.Id.myListView);            

            Items = new List<Person>();

            Items.Add(new Person() { FirstName = "Sebastian", LasName = "Higuita", Age = "19", Gender = "Male" });
            Items.Add(new Person() { FirstName = "Gabriel", LasName = "Martinez", Age = "29", Gender = "Male" });
            Items.Add(new Person() { FirstName = "Manuela", LasName = "Palacios", Age = "18", Gender = "Female" });

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Items);
            MyListViewAdapter adapter = new MyListViewAdapter(this, Items);

            myListView.Adapter = adapter;
            myListView.ItemClick += myListView_ItemClick;
            myListView.ItemLongClick += myListView_ItemLongClick;

            myListView.ItemClick += myListView_ItemClick2;
        }

        private void myListView_ItemClick2(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine("Second method subscription");
        }

        void myListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.Write(Items[e.Position].LasName);
        }

        void myListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(Items[e.Position].FirstName);
        }
    }
}


using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace items
{
    public class MyCustomListAdapter : BaseAdapter<User> 
    {
        Context _context;
        List<User> users;  
  
        public MyCustomListAdapter(List<User> users, Context context)  
        {  
            this.users = users;
            this._context = context;
        }  
  
        public override User this[int position]  
        {  
            get  
            {  
                return users[position];  
            }  
        }  
  
        public override int Count  
        {  
            get  
            {  
                 return users.Count;  
            }  
        }  
  
        public override long GetItemId(int position)  
        {  
            return position;  
        }  
  
        public override View GetView(int position, View convertView, ViewGroup parent)  
        {
            /*
            var view = convertView;  
  
            if(view==null)  
            {  
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.userRow, parent, false);  
  
                var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);  
                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);  
                var department = view.FindViewById<TextView>(Resource.Id.departmentTextView);  

                holder.Name.Click += Name_Click;
  
                view.Tag = new ViewHolder() { Photo = photo, Name = name, Department = department };  
            }  
  
            var holder = (ViewHolder)view.Tag;  
  
            //holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, users[position].ImageUrl));  
            holder.Name.Text = users[position].Name;  
            holder.Department.Text = users[position].Department;  
            */

            var usuario = users[position];
            ViewHolder mainViewHolder = null;

            if (convertView == null)
            {
                LayoutInflater inflater = LayoutInflater.From(_context);
                convertView = inflater.Inflate(Resource.Layout.userRow, parent, false);
                ViewHolder viewHolder = new ViewHolder();

                viewHolder.Name = convertView.FindViewById<TextView>(Resource.Id.nameTextView);  
                viewHolder.Department = convertView.FindViewById<TextView>(Resource.Id.departmentTextView);
                viewHolder.Id = convertView.FindViewById<TextView>(Resource.Id.idTextView);


                viewHolder.Name.Focusable = false;
                viewHolder.Name.FocusableInTouchMode = false;
                viewHolder.Name.Clickable = true;
                //viewHolder.Name.Click += Name_Click;
                viewHolder.Name.Click += (sender, e) => {
                    var count = Convert.ToInt32(viewHolder.Id.Text+"");
                    Toast.MakeText(_context, "" + count++, ToastLength.Short).Show();
                };

                convertView.Tag = viewHolder;
            }
            //else
            //{
                mainViewHolder = (ViewHolder)convertView.Tag;
                mainViewHolder.Name.Text = users[position].Name;
            mainViewHolder.Department.Text = users[position].Department;
            mainViewHolder.Id.Text = users[position].Id.ToString();

            mainViewHolder.Name.Focusable = false;
            mainViewHolder.Name.FocusableInTouchMode = false;
            mainViewHolder.Name.Clickable = true;
            //viewHolder.Name.Click += Name_Click;
            //mainViewHolder.Name.Click += (sender, e) => {
            //    Toast.MakeText(_context, "" + mainViewHolder.Name.Text, ToastLength.Short).Show();
            //};

            //}

  
            return convertView;  
  
        } 

        void Name_Click(object sender, EventArgs e)
        {
            Toast.MakeText(_context, "asd", ToastLength.Short).Show();
        }

    }
}

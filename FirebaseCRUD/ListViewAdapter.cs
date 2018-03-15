﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebaseCRUD;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace FirebaseCRUD
{
    public class ListViewAdapter : BaseAdapter
    {
        Activity activity;
        List<Account> lstAccounts;
        LayoutInflater inflater;
        public ListViewAdapter(Activity activity, List<Account> lstAccounts)
        {
            this.activity = activity;
            this.lstAccounts = lstAccounts;
        }

        public override int Count
        {
            get { return lstAccounts.Count; }
        }
        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            inflater = (LayoutInflater)activity.BaseContext.GetSystemService(Context.LayoutInflaterService);
            View itemView = inflater.Inflate(Resource.Layout.list_Item, null);
            var txtUser = itemView.FindViewById<TextView>(Resource.Id.list_name);
            var txtEmail = itemView.FindViewById<TextView>(Resource.Id.list_email);
            if (lstAccounts.Count > 0)
            {
                txtUser.Text = lstAccounts[position].name;
                txtEmail.Text = lstAccounts[position].email;
            }
            return itemView;
        }
    }
}
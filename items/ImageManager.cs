﻿using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics.Drawables;

namespace items
{
    public static class ImageManager
    {
        static Dictionary<string, Drawable> cache = new Dictionary<string, Drawable>();  
  
        public static Drawable Get(Context context, string url)  
        {  
            if (!cache.ContainsKey(url))  
            {  
                var drawable = Drawable.CreateFromStream(context.Assets.Open(url), null);  
  
                cache.Add(url, drawable);  
            }  
  
            return cache[url];  
        }  
    }
}

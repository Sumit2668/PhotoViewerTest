﻿using System;
using Xamarin.Forms;

namespace PhotoViewerTest
{
    public class PhotoView : ScrollView
    {
        #region Public Properties

        public static readonly BindableProperty ImageNameProperty = BindableProperty.Create("ImageName", typeof(string), typeof(PhotoView), string.Empty);
        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }

        public static readonly BindableProperty IsActiveProperty = BindableProperty.Create("IsActive", typeof(bool), typeof(PhotoView), false);
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

    #endregion
    #region Public Events
    public event EventHandler<EventArgs> Tap;

    protected virtual void OnHandleTap(EventArgs e)
    {
      var handler = Tap;
      if (handler != null)
        handler(this, e);
    }

    public void OnTap()
    {
      OnHandleTap(new EventArgs());
    }
    #endregion
  }
}
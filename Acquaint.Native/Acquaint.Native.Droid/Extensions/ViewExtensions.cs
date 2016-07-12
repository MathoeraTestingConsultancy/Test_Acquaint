﻿using Android.Views;
using Android.Widget;
using FFImageLoading.Views;
using FFImageLoading;
using FFImageLoading.Transformations;

namespace Acquaint.Native.Droid
{
	public static class ViewExtensions
	{
		public static TextView InflateAndBindTextView(this View parentView, int textViewResourceId, string text)
		{
			TextView textView = null;

			if (parentView != null)
			{
				textView = parentView.FindViewById<TextView>(textViewResourceId);

				if (textView != null)
				{
					textView.Text = text;
				}
			}

			return textView;
		}

		public static EditText InflateAndBindEditText(this View parentView, int textViewResourceId, string text)
		{
			EditText editText = null;

			if (parentView != null)
			{
				editText = parentView.FindViewById<EditText>(textViewResourceId);

				if (editText != null)
				{
					editText.Text = text;
				}
			}

			return editText;
		}

		public static ImageViewAsync InflateAndBindRemoteImageView(this View parentView, int imageViewResourceId, string imageUrl)
		{
			ImageViewAsync imageView = null;

			if (parentView != null)
			{
				imageView = parentView.FindViewById<ImageViewAsync>(imageViewResourceId);

				if (imageView != null)
				{
					ImageService.Instance.LoadUrl(imageUrl).Transform(new CircleTransformation()).Into(imageView);
				}
			}

			return imageView;
		}

		public static ImageView InflateAndBindLocalImageViewByResource(this View parentView, int imageViewResourceId, int resourceId)
		{
			ImageView imageView = null;

			if (parentView != null)
			{
				imageView = parentView.FindViewById<ImageView>(imageViewResourceId);

				imageView.SetImageResource(resourceId);
			}

			return imageView;
		}
	}
}


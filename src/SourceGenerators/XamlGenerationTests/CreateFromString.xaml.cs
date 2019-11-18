﻿using System;
using Windows.UI.Xaml.Controls;

namespace XamlGenerationTests.Shared
{
	public sealed partial class CreateFromString : UserControl
	{
		public CreateFromString()
		{
			this.InitializeComponent();
		}
	}
}

namespace XamlGenerationTests.Shared.CreateFromStringTests
{
	public partial class MyLocationPointControl : Control
	{
		public Location LocationPoint { get; set; }
	}

	[Windows.Foundation.Metadata.CreateFromString(MethodName = "XamlGenerationTests.Shared.CreateFromStringTests.Location.ConvertToLatLong")]
	public class Location
	{
		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public static Location ConvertToLatLong(string rawString)
		{
			var coords = rawString.Split(',');

			return new Location
			{
				Latitude = Convert.ToDouble(coords[0]),
				Longitude = Convert.ToDouble(coords[1])
			};
		}
	}
}
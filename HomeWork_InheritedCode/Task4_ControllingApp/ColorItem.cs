using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_ControllingApp
{
	public class ColorItem
	{
		public string Name { get; set; }
		public Color Value { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}

	public class ColorItemList
	{
		public ColorItem[] Colors { get; }
		public ColorItemList()
		{
			Colors = new ColorItem[]
			{
				new ColorItem {Name = "White", Value = Color.White},
				new ColorItem {Name = "Red", Value = Color.Red},
				new ColorItem {Name = "Black", Value = Color.Black},
				new ColorItem {Name = "Blue", Value = Color.Blue},
				new ColorItem {Name = "Yellow", Value = Color.Yellow},
				new ColorItem {Name = "Green", Value = Color.Green},
				new ColorItem {Name = "DarkGray", Value = Color.DarkGray},
				new ColorItem {Name = "BlueViolet", Value = Color.BlueViolet},
				new ColorItem {Name = "Orange", Value = Color.Orange},
			};
		}
	}
}

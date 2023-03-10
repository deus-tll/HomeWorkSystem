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
			Colors
		}
	}
}

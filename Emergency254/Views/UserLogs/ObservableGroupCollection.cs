﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Emergency254.Utils
{
	public class ObservableGroupCollection<S, T>: ObservableCollection<T>
	{
		private readonly S _key;
		public ObservableGroupCollection(IGrouping<S,T> group) : base(group)
		{
			_key = group.Key;
		}
		public S Key
		{
			get
			{
				return _key;
			}
		}
	}
}

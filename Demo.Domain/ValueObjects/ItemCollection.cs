using Demo.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Demo.Domain.ValueObjects
{
	public abstract class ItemCollection<T>
	{
		private readonly IList<T> _items;
		public abstract bool REMOVES_DOUBLES { get; }

		public ItemCollection() { _items = new List<T>(); }
		public ItemCollection(IList<T> list) { _items = list; }

		public IReadOnlyCollection<T> GetReadOnly()
		{
			IReadOnlyCollection<T> readOnly = new ReadOnlyCollection<T>(_items);
			return readOnly;
		}

		public void Add(T item)
		{
			if(REMOVES_DOUBLES && _items.Contains(item))
			{ return; }
			else
			{ _items.Add(item); }
		}

		public bool Remove(T item) => _items.Remove(item);
		public bool Contains(T item) => _items.Contains(item);
		public int Count
		{
			get { return _items.Count; }
		}
		public bool IsEmpty
		{
			get { return _items.Count != 0; }
		}

		public void AddRange(params T[] items)
		{
			for (int x = 0; x < items.Length; x++)
			{
				if (REMOVES_DOUBLES)
				{
					if (_items.Contains(items[x]))
					{ break; }

					else
					{ _items.Add(items[x]); }
				}

				else
				{ _items.Add(items[x]); }
			}
		}

		public bool CointainsRange(params T[] items)
		{
			for(int x = 0; x < items.Length; x++)
			{
				if (!_items.Contains(items[x]))
				{ return false; }
			}
			return true;
		}
	}
}
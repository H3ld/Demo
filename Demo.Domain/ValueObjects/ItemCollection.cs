using Demo.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Demo.Domain.ValueObjects
{
	public abstract class ItemCollection<T>
	{
		private readonly IList<T> _items;

		public ItemCollection() { _items = new List<T>(); }

		public IReadOnlyCollection<T> GetItemIds()
		{
			IReadOnlyCollection<T> ids = new ReadOnlyCollection<T>(_items);
			return ids;
		}

		public void Add(T item) => _items.Add(item);
		public bool Remove(T item) => _items.Remove(item);
		public bool Contains(T item) => _items.Contains(item);

		public bool IsEmpty
		{
			get { return _items.Count != 0; }
		}
	}
}
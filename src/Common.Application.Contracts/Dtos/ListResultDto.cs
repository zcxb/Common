using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Application.Dtos
{
    public class ListResultDto<T>
    {
        private IReadOnlyList<T> _items;

        public IReadOnlyList<T> Items
        {
            get
            {
                return _items ?? (_items = new List<T>());
            }
            set
            {
                _items = value;
            }
        }

        public ListResultDto(IReadOnlyList<T> items)
        {
            _items = items;
        }
    }
}

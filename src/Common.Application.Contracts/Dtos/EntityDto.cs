using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Application.Dtos
{
    public class EntityDto<TKey>
    {
        public TKey Id { get; set; }
    }
}

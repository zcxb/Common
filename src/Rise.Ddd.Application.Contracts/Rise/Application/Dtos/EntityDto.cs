using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Rise.Application.Dtos
{
    public class EntityDto<TKey>
    {
        [JsonPropertyName("id")]
        public TKey Id { get; set; }
    }
}

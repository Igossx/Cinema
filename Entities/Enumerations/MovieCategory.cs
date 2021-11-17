using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cinema.Entities.Enumerations
{
    public enum MovieCategory
    {
        Horror = 1,
        Science_Fiction,
        Action,
        Adventure,
        Animated,
        Comedy,
        Drama,
        Thriller,
        Western,
        Historical
    }
}

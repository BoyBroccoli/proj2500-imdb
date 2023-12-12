using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2500_imdb.Models
{
    public partial class Title
    {
        public string? RuntimeInfo
        {
            get
            {
                return RuntimeMinutes == null ? null : $"{RuntimeMinutes} minutes";
            }
        }
    }
}

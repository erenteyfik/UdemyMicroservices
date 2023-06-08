using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public string CouserCollectionName { get; set; }
        public string CategoryColletionName { get; set; }
        public string ConnetionString { get; set; }
        public string DatabaseName { get; set; }
    }
}

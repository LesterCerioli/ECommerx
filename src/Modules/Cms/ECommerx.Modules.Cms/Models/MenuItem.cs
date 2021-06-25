using ECommex.Infrastructure.Models;
using ECommex.Modules.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerx.Modules.Cms.Models
{
    public class MenuItem : EntityBase
    {
        public long ParentId { get; set; }

        public MenuItem Parent { get; set; }
        
        public IList<MenuItem> Children { get; protected set; } = new List<MenuItem>();
        
        public long MenuId { get; set; }

        public Menu Menu { get; set; }

        public long? EntityId { get; set; }
        
        public Entity Entity { get; set; }
        
        [StringLength(450)]
        public string CustomLink { get; set; }

        [StringLength(450)]
        public string Name { get; set; }

        public int DisplayNameOrder { get; set; }

    }
}

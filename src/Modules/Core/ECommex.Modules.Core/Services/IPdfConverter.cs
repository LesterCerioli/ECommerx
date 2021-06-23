using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommex.Modules.Core.Services
{
    public interface IPdfConverter
    {
        byte[] Convert(string htmlContent);
    }
}

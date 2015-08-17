using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.Scripts
{
    public interface IScriptsLogic
    {
        string GetHeaderScripts();
        string GetStartBodyScripts();
        string GetEndBodyScripts();
    }
}

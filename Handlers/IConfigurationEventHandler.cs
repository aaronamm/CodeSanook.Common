using Orchard.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codesanook.Common.Handlers
{
    public interface IConfigurationEventHandler:IEventHandler
    {
        void OnInitialized(string settingTypeFullName);
    }
}

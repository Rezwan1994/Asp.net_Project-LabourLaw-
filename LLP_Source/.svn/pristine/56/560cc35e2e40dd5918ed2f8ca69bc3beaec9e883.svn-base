using LLP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLP.Facade
{
    public class BaseFacade : IDisposable
    {
        protected ClientContext _ClientContext { get; set; }
        public BaseFacade()
        {
        }
        public BaseFacade(ClientContext clientContext)
        {
            _ClientContext = clientContext;
        }

        /// <summary>
        ///  IDisposable Members
        /// </summary>
        public void Dispose()
        {
        }
    }
}

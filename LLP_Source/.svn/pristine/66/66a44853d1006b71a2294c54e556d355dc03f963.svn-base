using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "ELMAH_ErrorList", Namespace = "http://www.piistech.com//list")]	
	public class ELMAH_ErrorList : BaseCollection<ELMAH_Error>
	{
		#region Constructors
	    public ELMAH_ErrorList() : base() { }
        public ELMAH_ErrorList(ELMAH_Error[] list) : base(list) { }
        public ELMAH_ErrorList(List<ELMAH_Error> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "InvoiceDetailList", Namespace = "http://www.piistech.com//list")]	
	public class InvoiceDetailList : BaseCollection<InvoiceDetail>
	{
		#region Constructors
	    public InvoiceDetailList() : base() { }
        public InvoiceDetailList(InvoiceDetail[] list) : base(list) { }
        public InvoiceDetailList(List<InvoiceDetail> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


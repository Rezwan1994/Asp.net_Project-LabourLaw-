using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "ChapterList", Namespace = "http://www.piistech.com//list")]	
	public class ChapterList : BaseCollection<Chapter>
	{
		#region Constructors
	    public ChapterList() : base() { }
        public ChapterList(Chapter[] list) : base(list) { }
        public ChapterList(List<Chapter> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


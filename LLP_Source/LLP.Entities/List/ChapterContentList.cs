using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "ChapterContentList", Namespace = "http://www.piistech.com//list")]	
	public class ChapterContentList : BaseCollection<ChapterContent>
	{
		#region Constructors
	    public ChapterContentList() : base() { }
        public ChapterContentList(ChapterContent[] list) : base(list) { }
        public ChapterContentList(List<ChapterContent> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


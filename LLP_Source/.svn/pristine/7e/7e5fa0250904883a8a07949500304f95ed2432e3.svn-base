using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "UserActivityList", Namespace = "http://www.piistech.com//list")]	
	public class UserActivityList : BaseCollection<UserActivity>
	{
		#region Constructors
	    public UserActivityList() : base() { }
        public UserActivityList(UserActivity[] list) : base(list) { }
        public UserActivityList(List<UserActivity> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "UserBranchList", Namespace = "http://www.piistech.com//list")]	
	public class UserBranchList : BaseCollection<UserBranch>
	{
		#region Constructors
	    public UserBranchList() : base() { }
        public UserBranchList(UserBranch[] list) : base(list) { }
        public UserBranchList(List<UserBranch> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


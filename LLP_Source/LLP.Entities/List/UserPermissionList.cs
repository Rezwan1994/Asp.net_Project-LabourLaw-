using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "UserPermissionList", Namespace = "http://www.piistech.com//list")]	
	public class UserPermissionList : BaseCollection<UserPermission>
	{
		#region Constructors
	    public UserPermissionList() : base() { }
        public UserPermissionList(UserPermission[] list) : base(list) { }
        public UserPermissionList(List<UserPermission> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


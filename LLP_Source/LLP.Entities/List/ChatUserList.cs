using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

using LLP.Framework;

namespace LLP.Entities.List
{
	[Serializable]
	[CollectionDataContract(Name = "ChatUserList", Namespace = "http://www.piistech.com//list")]	
	public class ChatUserList : BaseCollection<ChatUser>
	{
		#region Constructors
	    public ChatUserList() : base() { }
        public ChatUserList(ChatUser[] list) : base(list) { }
        public ChatUserList(List<ChatUser> list) : base(list) { }
		#endregion
		
		#region Custom Methods
		#endregion
	}	
}


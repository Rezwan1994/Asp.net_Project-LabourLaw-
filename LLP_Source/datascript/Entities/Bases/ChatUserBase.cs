using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "ChatUserBase", Namespace = "http://www.piistech.com//entities")]
	public class ChatUserBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			ChatUserId = 1,
			Name = 2,
			Email = 3,
			Phone = 4,
			JoinDate = 5,
			ChatEnd = 6,
			Ip = 7,
			UserAgent = 8,
			EmployeeId = 9
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_ChatUserId = "ChatUserId";		            
		public const string Property_Name = "Name";		            
		public const string Property_Email = "Email";		            
		public const string Property_Phone = "Phone";		            
		public const string Property_JoinDate = "JoinDate";		            
		public const string Property_ChatEnd = "ChatEnd";		            
		public const string Property_Ip = "Ip";		            
		public const string Property_UserAgent = "UserAgent";		            
		public const string Property_EmployeeId = "EmployeeId";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private Guid _ChatUserId;	            
		private String _Name;	            
		private String _Email;	            
		private String _Phone;	            
		private DateTime _JoinDate;	            
		private Nullable<DateTime> _ChatEnd;	            
		private String _Ip;	            
		private String _UserAgent;	            
		private Guid _EmployeeId;	            
		#endregion
		
		#region Properties		
		[DataMember]
		public Int32 Id
		{	
			get{ return _Id; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Id, value, _Id);
				if (PropertyChanging(args))
				{
					_Id = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Guid ChatUserId
		{	
			get{ return _ChatUserId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ChatUserId, value, _ChatUserId);
				if (PropertyChanging(args))
				{
					_ChatUserId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Name
		{	
			get{ return _Name; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Name, value, _Name);
				if (PropertyChanging(args))
				{
					_Name = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Email
		{	
			get{ return _Email; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Email, value, _Email);
				if (PropertyChanging(args))
				{
					_Email = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Phone
		{	
			get{ return _Phone; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Phone, value, _Phone);
				if (PropertyChanging(args))
				{
					_Phone = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public DateTime JoinDate
		{	
			get{ return _JoinDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_JoinDate, value, _JoinDate);
				if (PropertyChanging(args))
				{
					_JoinDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> ChatEnd
		{	
			get{ return _ChatEnd; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ChatEnd, value, _ChatEnd);
				if (PropertyChanging(args))
				{
					_ChatEnd = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Ip
		{	
			get{ return _Ip; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Ip, value, _Ip);
				if (PropertyChanging(args))
				{
					_Ip = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String UserAgent
		{	
			get{ return _UserAgent; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_UserAgent, value, _UserAgent);
				if (PropertyChanging(args))
				{
					_UserAgent = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Guid EmployeeId
		{	
			get{ return _EmployeeId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_EmployeeId, value, _EmployeeId);
				if (PropertyChanging(args))
				{
					_EmployeeId = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  ChatUserBase Clone()
		{
			ChatUserBase newObj = new  ChatUserBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.ChatUserId = this.ChatUserId;						
			newObj.Name = this.Name;						
			newObj.Email = this.Email;						
			newObj.Phone = this.Phone;						
			newObj.JoinDate = this.JoinDate;						
			newObj.ChatEnd = this.ChatEnd;						
			newObj.Ip = this.Ip;						
			newObj.UserAgent = this.UserAgent;						
			newObj.EmployeeId = this.EmployeeId;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(ChatUserBase.Property_Id, Id);				
			info.AddValue(ChatUserBase.Property_ChatUserId, ChatUserId);				
			info.AddValue(ChatUserBase.Property_Name, Name);				
			info.AddValue(ChatUserBase.Property_Email, Email);				
			info.AddValue(ChatUserBase.Property_Phone, Phone);				
			info.AddValue(ChatUserBase.Property_JoinDate, JoinDate);				
			info.AddValue(ChatUserBase.Property_ChatEnd, ChatEnd);				
			info.AddValue(ChatUserBase.Property_Ip, Ip);				
			info.AddValue(ChatUserBase.Property_UserAgent, UserAgent);				
			info.AddValue(ChatUserBase.Property_EmployeeId, EmployeeId);				
		}
		#endregion

		
	}
}

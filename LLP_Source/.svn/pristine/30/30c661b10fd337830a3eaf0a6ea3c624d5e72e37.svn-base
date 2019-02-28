using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "ChatMessageBase", Namespace = "http://www.piistech.com//entities")]
	public class ChatMessageBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			SenderId = 1,
			RecieverId = 2,
			Message = 3,
			SendDate = 4,
			ReadDate = 5
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_SenderId = "SenderId";		            
		public const string Property_RecieverId = "RecieverId";		            
		public const string Property_Message = "Message";		            
		public const string Property_SendDate = "SendDate";		            
		public const string Property_ReadDate = "ReadDate";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private Guid _SenderId;	            
		private Guid _RecieverId;	            
		private String _Message;	            
		private DateTime _SendDate;	            
		private Nullable<DateTime> _ReadDate;	            
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
		public Guid SenderId
		{	
			get{ return _SenderId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_SenderId, value, _SenderId);
				if (PropertyChanging(args))
				{
					_SenderId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Guid RecieverId
		{	
			get{ return _RecieverId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_RecieverId, value, _RecieverId);
				if (PropertyChanging(args))
				{
					_RecieverId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Message
		{	
			get{ return _Message; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Message, value, _Message);
				if (PropertyChanging(args))
				{
					_Message = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public DateTime SendDate
		{	
			get{ return _SendDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_SendDate, value, _SendDate);
				if (PropertyChanging(args))
				{
					_SendDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> ReadDate
		{	
			get{ return _ReadDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ReadDate, value, _ReadDate);
				if (PropertyChanging(args))
				{
					_ReadDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  ChatMessageBase Clone()
		{
			ChatMessageBase newObj = new  ChatMessageBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.SenderId = this.SenderId;						
			newObj.RecieverId = this.RecieverId;						
			newObj.Message = this.Message;						
			newObj.SendDate = this.SendDate;						
			newObj.ReadDate = this.ReadDate;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(ChatMessageBase.Property_Id, Id);				
			info.AddValue(ChatMessageBase.Property_SenderId, SenderId);				
			info.AddValue(ChatMessageBase.Property_RecieverId, RecieverId);				
			info.AddValue(ChatMessageBase.Property_Message, Message);				
			info.AddValue(ChatMessageBase.Property_SendDate, SendDate);				
			info.AddValue(ChatMessageBase.Property_ReadDate, ReadDate);				
		}
		#endregion

		
	}
}

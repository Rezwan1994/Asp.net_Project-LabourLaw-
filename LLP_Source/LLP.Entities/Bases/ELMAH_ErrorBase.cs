using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "ELMAH_ErrorBase", Namespace = "http://www.piistech.com//entities")]
	public class ELMAH_ErrorBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			ErrorId = 0,
			Application = 1,
			Host = 2,
			Type = 3,
			Source = 4,
			Message = 5,
			User = 6,
			StatusCode = 7,
			TimeUtc = 8,
			Sequence = 9,
			AllXml = 10
		}
		#endregion
	
		#region Constants
		public const string Property_ErrorId = "ErrorId";		            
		public const string Property_Application = "Application";		            
		public const string Property_Host = "Host";		            
		public const string Property_Type = "Type";		            
		public const string Property_Source = "Source";		            
		public const string Property_Message = "Message";		            
		public const string Property_User = "User";		            
		public const string Property_StatusCode = "StatusCode";		            
		public const string Property_TimeUtc = "TimeUtc";		            
		public const string Property_Sequence = "Sequence";		            
		public const string Property_AllXml = "AllXml";		            
		#endregion
		
		#region Private Data Types
		private Guid _ErrorId;	            
		private String _Application;	            
		private String _Host;	            
		private String _Type;	            
		private String _Source;	            
		private String _Message;	            
		private String _User;	            
		private Int32 _StatusCode;	            
		private DateTime _TimeUtc;	            
		private Int32 _Sequence;	            
		private String _AllXml;	            
		#endregion
		
		#region Properties		
		[DataMember]
		public Guid ErrorId
		{	
			get{ return _ErrorId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ErrorId, value, _ErrorId);
				if (PropertyChanging(args))
				{
					_ErrorId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Application
		{	
			get{ return _Application; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Application, value, _Application);
				if (PropertyChanging(args))
				{
					_Application = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Host
		{	
			get{ return _Host; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Host, value, _Host);
				if (PropertyChanging(args))
				{
					_Host = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Type
		{	
			get{ return _Type; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Type, value, _Type);
				if (PropertyChanging(args))
				{
					_Type = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Source
		{	
			get{ return _Source; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Source, value, _Source);
				if (PropertyChanging(args))
				{
					_Source = value;
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
		public String User
		{	
			get{ return _User; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_User, value, _User);
				if (PropertyChanging(args))
				{
					_User = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Int32 StatusCode
		{	
			get{ return _StatusCode; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_StatusCode, value, _StatusCode);
				if (PropertyChanging(args))
				{
					_StatusCode = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public DateTime TimeUtc
		{	
			get{ return _TimeUtc; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_TimeUtc, value, _TimeUtc);
				if (PropertyChanging(args))
				{
					_TimeUtc = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Int32 Sequence
		{	
			get{ return _Sequence; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Sequence, value, _Sequence);
				if (PropertyChanging(args))
				{
					_Sequence = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String AllXml
		{	
			get{ return _AllXml; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_AllXml, value, _AllXml);
				if (PropertyChanging(args))
				{
					_AllXml = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  ELMAH_ErrorBase Clone()
		{
			ELMAH_ErrorBase newObj = new  ELMAH_ErrorBase();
			base.CloneBase(newObj);
			newObj.ErrorId = this.ErrorId;						
			newObj.Application = this.Application;						
			newObj.Host = this.Host;						
			newObj.Type = this.Type;						
			newObj.Source = this.Source;						
			newObj.Message = this.Message;						
			newObj.User = this.User;						
			newObj.StatusCode = this.StatusCode;						
			newObj.TimeUtc = this.TimeUtc;						
			newObj.Sequence = this.Sequence;						
			newObj.AllXml = this.AllXml;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(ELMAH_ErrorBase.Property_ErrorId, ErrorId);				
			info.AddValue(ELMAH_ErrorBase.Property_Application, Application);				
			info.AddValue(ELMAH_ErrorBase.Property_Host, Host);				
			info.AddValue(ELMAH_ErrorBase.Property_Type, Type);				
			info.AddValue(ELMAH_ErrorBase.Property_Source, Source);				
			info.AddValue(ELMAH_ErrorBase.Property_Message, Message);				
			info.AddValue(ELMAH_ErrorBase.Property_User, User);				
			info.AddValue(ELMAH_ErrorBase.Property_StatusCode, StatusCode);				
			info.AddValue(ELMAH_ErrorBase.Property_TimeUtc, TimeUtc);				
			info.AddValue(ELMAH_ErrorBase.Property_Sequence, Sequence);				
			info.AddValue(ELMAH_ErrorBase.Property_AllXml, AllXml);				
		}
		#endregion

		
	}
}

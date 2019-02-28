using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "GlobalSettingBase", Namespace = "http://www.piistech.com//entities")]
	public class GlobalSettingBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			CompanyId = 1,
			SearchKey = 2,
			Value = 3,
			IsActive = 4
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_CompanyId = "CompanyId";		            
		public const string Property_SearchKey = "SearchKey";		            
		public const string Property_Value = "Value";		            
		public const string Property_IsActive = "IsActive";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private Guid _CompanyId;	            
		private String _SearchKey;	            
		private String _Value;	            
		private Nullable<Boolean> _IsActive;	            
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
		public Guid CompanyId
		{	
			get{ return _CompanyId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CompanyId, value, _CompanyId);
				if (PropertyChanging(args))
				{
					_CompanyId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String SearchKey
		{	
			get{ return _SearchKey; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_SearchKey, value, _SearchKey);
				if (PropertyChanging(args))
				{
					_SearchKey = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Value
		{	
			get{ return _Value; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Value, value, _Value);
				if (PropertyChanging(args))
				{
					_Value = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Boolean> IsActive
		{	
			get{ return _IsActive; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsActive, value, _IsActive);
				if (PropertyChanging(args))
				{
					_IsActive = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  GlobalSettingBase Clone()
		{
			GlobalSettingBase newObj = new  GlobalSettingBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.CompanyId = this.CompanyId;						
			newObj.SearchKey = this.SearchKey;						
			newObj.Value = this.Value;						
			newObj.IsActive = this.IsActive;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(GlobalSettingBase.Property_Id, Id);				
			info.AddValue(GlobalSettingBase.Property_CompanyId, CompanyId);				
			info.AddValue(GlobalSettingBase.Property_SearchKey, SearchKey);				
			info.AddValue(GlobalSettingBase.Property_Value, Value);				
			info.AddValue(GlobalSettingBase.Property_IsActive, IsActive);				
		}
		#endregion

		
	}
}

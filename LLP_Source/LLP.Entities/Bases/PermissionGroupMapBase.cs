using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "PermissionGroupMapBase", Namespace = "http://www.piistech.com//entities")]
	public class PermissionGroupMapBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			PermissionGroupId = 1,
			PermissionId = 2,
			IsActive = 3
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_PermissionGroupId = "PermissionGroupId";		            
		public const string Property_PermissionId = "PermissionId";		            
		public const string Property_IsActive = "IsActive";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private Int32 _PermissionGroupId;	            
		private Int32 _PermissionId;	            
		private Boolean _IsActive;	            
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
		public Int32 PermissionGroupId
		{	
			get{ return _PermissionGroupId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_PermissionGroupId, value, _PermissionGroupId);
				if (PropertyChanging(args))
				{
					_PermissionGroupId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Int32 PermissionId
		{	
			get{ return _PermissionId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_PermissionId, value, _PermissionId);
				if (PropertyChanging(args))
				{
					_PermissionId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Boolean IsActive
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
		public  PermissionGroupMapBase Clone()
		{
			PermissionGroupMapBase newObj = new  PermissionGroupMapBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.PermissionGroupId = this.PermissionGroupId;						
			newObj.PermissionId = this.PermissionId;						
			newObj.IsActive = this.IsActive;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(PermissionGroupMapBase.Property_Id, Id);				
			info.AddValue(PermissionGroupMapBase.Property_PermissionGroupId, PermissionGroupId);				
			info.AddValue(PermissionGroupMapBase.Property_PermissionId, PermissionId);				
			info.AddValue(PermissionGroupMapBase.Property_IsActive, IsActive);				
		}
		#endregion

		
	}
}

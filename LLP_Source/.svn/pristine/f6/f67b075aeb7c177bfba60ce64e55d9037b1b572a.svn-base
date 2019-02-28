using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "ChapterBase", Namespace = "http://www.piistech.com//entities")]
	public class ChapterBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			ChapterNo = 1,
			Name = 2,
			Type = 3,
			Description = 4
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_ChapterNo = "ChapterNo";		            
		public const string Property_Name = "Name";		            
		public const string Property_Type = "Type";		            
		public const string Property_Description = "Description";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private String _ChapterNo;	            
		private String _Name;	            
		private String _Type;	            
		private String _Description;	            
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
		public String ChapterNo
		{	
			get{ return _ChapterNo; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ChapterNo, value, _ChapterNo);
				if (PropertyChanging(args))
				{
					_ChapterNo = value;
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
		public String Description
		{	
			get{ return _Description; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Description, value, _Description);
				if (PropertyChanging(args))
				{
					_Description = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  ChapterBase Clone()
		{
			ChapterBase newObj = new  ChapterBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.ChapterNo = this.ChapterNo;						
			newObj.Name = this.Name;						
			newObj.Type = this.Type;						
			newObj.Description = this.Description;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(ChapterBase.Property_Id, Id);				
			info.AddValue(ChapterBase.Property_ChapterNo, ChapterNo);				
			info.AddValue(ChapterBase.Property_Name, Name);				
			info.AddValue(ChapterBase.Property_Type, Type);				
			info.AddValue(ChapterBase.Property_Description, Description);				
		}
		#endregion

		
	}
}

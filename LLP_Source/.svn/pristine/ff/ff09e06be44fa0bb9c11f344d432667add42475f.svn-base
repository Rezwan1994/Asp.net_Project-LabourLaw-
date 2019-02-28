using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "ChapterContentBase", Namespace = "http://www.piistech.com//entities")]
	public class ChapterContentBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			TitleNo = 1,
			Title = 2,
			CpContent = 3,
			ChapterId = 4,
			ParentId = 5,
			PageUrl = 6
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_TitleNo = "TitleNo";		            
		public const string Property_Title = "Title";		            
		public const string Property_CpContent = "CpContent";		            
		public const string Property_ChapterId = "ChapterId";		            
		public const string Property_ParentId = "ParentId";		            
		public const string Property_PageUrl = "PageUrl";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private String _TitleNo;	            
		private String _Title;	            
		private String _CpContent;	            
		private Nullable<Int32> _ChapterId;	            
		private Nullable<Int32> _ParentId;	            
		private String _PageUrl;	            
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
		public String TitleNo
		{	
			get{ return _TitleNo; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_TitleNo, value, _TitleNo);
				if (PropertyChanging(args))
				{
					_TitleNo = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Title
		{	
			get{ return _Title; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Title, value, _Title);
				if (PropertyChanging(args))
				{
					_Title = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String CpContent
		{	
			get{ return _CpContent; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CpContent, value, _CpContent);
				if (PropertyChanging(args))
				{
					_CpContent = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Int32> ChapterId
		{	
			get{ return _ChapterId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ChapterId, value, _ChapterId);
				if (PropertyChanging(args))
				{
					_ChapterId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Int32> ParentId
		{	
			get{ return _ParentId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ParentId, value, _ParentId);
				if (PropertyChanging(args))
				{
					_ParentId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String PageUrl
		{	
			get{ return _PageUrl; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_PageUrl, value, _PageUrl);
				if (PropertyChanging(args))
				{
					_PageUrl = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  ChapterContentBase Clone()
		{
			ChapterContentBase newObj = new  ChapterContentBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.TitleNo = this.TitleNo;						
			newObj.Title = this.Title;						
			newObj.CpContent = this.CpContent;						
			newObj.ChapterId = this.ChapterId;						
			newObj.ParentId = this.ParentId;						
			newObj.PageUrl = this.PageUrl;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(ChapterContentBase.Property_Id, Id);				
			info.AddValue(ChapterContentBase.Property_TitleNo, TitleNo);				
			info.AddValue(ChapterContentBase.Property_Title, Title);				
			info.AddValue(ChapterContentBase.Property_CpContent, CpContent);				
			info.AddValue(ChapterContentBase.Property_ChapterId, ChapterId);				
			info.AddValue(ChapterContentBase.Property_ParentId, ParentId);				
			info.AddValue(ChapterContentBase.Property_PageUrl, PageUrl);				
		}
		#endregion

		
	}
}

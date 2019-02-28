using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "EmployeeBase", Namespace = "http://www.piistech.com//entities")]
	public class EmployeeBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			EmployeeId = 1,
			UserId = 2,
			Title = 3,
			FirstName = 4,
			LastName = 5,
			Email = 6,
			Street = 7,
			City = 8,
			State = 9,
			ZipCode = 10,
			Country = 11,
			Phone = 12,
			SSN = 13,
			IsActive = 14,
			IsDeleted = 15,
			IsInstaller = 16,
			IsSalesPerson = 17,
			IsServiceCall = 18,
			HireDate = 19,
			ProfilePicture = 20,
			Session = 21,
			JobTitle = 22,
			PlaceOfBirth = 23,
			SalesCommissionStructure = 24,
			TechCommissionStructure = 25,
			RecruitmentProcess = 26,
			Recruited = 27,
			CreatedDate = 28,
			Status = 29,
			LastUpdatedBy = 30,
			LastUpdatedDate = 31
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_EmployeeId = "EmployeeId";		            
		public const string Property_UserId = "UserId";		            
		public const string Property_Title = "Title";		            
		public const string Property_FirstName = "FirstName";		            
		public const string Property_LastName = "LastName";		            
		public const string Property_Email = "Email";		            
		public const string Property_Street = "Street";		            
		public const string Property_City = "City";		            
		public const string Property_State = "State";		            
		public const string Property_ZipCode = "ZipCode";		            
		public const string Property_Country = "Country";		            
		public const string Property_Phone = "Phone";		            
		public const string Property_SSN = "SSN";		            
		public const string Property_IsActive = "IsActive";		            
		public const string Property_IsDeleted = "IsDeleted";		            
		public const string Property_IsInstaller = "IsInstaller";		            
		public const string Property_IsSalesPerson = "IsSalesPerson";		            
		public const string Property_IsServiceCall = "IsServiceCall";		            
		public const string Property_HireDate = "HireDate";		            
		public const string Property_ProfilePicture = "ProfilePicture";		            
		public const string Property_Session = "Session";		            
		public const string Property_JobTitle = "JobTitle";		            
		public const string Property_PlaceOfBirth = "PlaceOfBirth";		            
		public const string Property_SalesCommissionStructure = "SalesCommissionStructure";		            
		public const string Property_TechCommissionStructure = "TechCommissionStructure";		            
		public const string Property_RecruitmentProcess = "RecruitmentProcess";		            
		public const string Property_Recruited = "Recruited";		            
		public const string Property_CreatedDate = "CreatedDate";		            
		public const string Property_Status = "Status";		            
		public const string Property_LastUpdatedBy = "LastUpdatedBy";		            
		public const string Property_LastUpdatedDate = "LastUpdatedDate";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private Guid _EmployeeId;	            
		private Guid _UserId;	            
		private String _Title;	            
		private String _FirstName;	            
		private String _LastName;	            
		private String _Email;	            
		private String _Street;	            
		private String _City;	            
		private String _State;	            
		private String _ZipCode;	            
		private String _Country;	            
		private String _Phone;	            
		private String _SSN;	            
		private Boolean _IsActive;	            
		private Boolean _IsDeleted;	            
		private Boolean _IsInstaller;	            
		private Boolean _IsSalesPerson;	            
		private Boolean _IsServiceCall;	            
		private Nullable<DateTime> _HireDate;	            
		private String _ProfilePicture;	            
		private String _Session;	            
		private String _JobTitle;	            
		private String _PlaceOfBirth;	            
		private String _SalesCommissionStructure;	            
		private String _TechCommissionStructure;	            
		private Nullable<Boolean> _RecruitmentProcess;	            
		private Nullable<Boolean> _Recruited;	            
		private Nullable<DateTime> _CreatedDate;	            
		private String _Status;	            
		private String _LastUpdatedBy;	            
		private Nullable<DateTime> _LastUpdatedDate;	            
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

		[DataMember]
		public Guid UserId
		{	
			get{ return _UserId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_UserId, value, _UserId);
				if (PropertyChanging(args))
				{
					_UserId = value;
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
		public String FirstName
		{	
			get{ return _FirstName; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_FirstName, value, _FirstName);
				if (PropertyChanging(args))
				{
					_FirstName = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String LastName
		{	
			get{ return _LastName; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_LastName, value, _LastName);
				if (PropertyChanging(args))
				{
					_LastName = value;
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
		public String Street
		{	
			get{ return _Street; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Street, value, _Street);
				if (PropertyChanging(args))
				{
					_Street = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String City
		{	
			get{ return _City; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_City, value, _City);
				if (PropertyChanging(args))
				{
					_City = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String State
		{	
			get{ return _State; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_State, value, _State);
				if (PropertyChanging(args))
				{
					_State = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String ZipCode
		{	
			get{ return _ZipCode; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ZipCode, value, _ZipCode);
				if (PropertyChanging(args))
				{
					_ZipCode = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Country
		{	
			get{ return _Country; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Country, value, _Country);
				if (PropertyChanging(args))
				{
					_Country = value;
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
		public String SSN
		{	
			get{ return _SSN; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_SSN, value, _SSN);
				if (PropertyChanging(args))
				{
					_SSN = value;
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

		[DataMember]
		public Boolean IsDeleted
		{	
			get{ return _IsDeleted; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsDeleted, value, _IsDeleted);
				if (PropertyChanging(args))
				{
					_IsDeleted = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Boolean IsInstaller
		{	
			get{ return _IsInstaller; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsInstaller, value, _IsInstaller);
				if (PropertyChanging(args))
				{
					_IsInstaller = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Boolean IsSalesPerson
		{	
			get{ return _IsSalesPerson; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsSalesPerson, value, _IsSalesPerson);
				if (PropertyChanging(args))
				{
					_IsSalesPerson = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Boolean IsServiceCall
		{	
			get{ return _IsServiceCall; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsServiceCall, value, _IsServiceCall);
				if (PropertyChanging(args))
				{
					_IsServiceCall = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> HireDate
		{	
			get{ return _HireDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_HireDate, value, _HireDate);
				if (PropertyChanging(args))
				{
					_HireDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String ProfilePicture
		{	
			get{ return _ProfilePicture; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ProfilePicture, value, _ProfilePicture);
				if (PropertyChanging(args))
				{
					_ProfilePicture = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Session
		{	
			get{ return _Session; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Session, value, _Session);
				if (PropertyChanging(args))
				{
					_Session = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String JobTitle
		{	
			get{ return _JobTitle; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_JobTitle, value, _JobTitle);
				if (PropertyChanging(args))
				{
					_JobTitle = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String PlaceOfBirth
		{	
			get{ return _PlaceOfBirth; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_PlaceOfBirth, value, _PlaceOfBirth);
				if (PropertyChanging(args))
				{
					_PlaceOfBirth = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String SalesCommissionStructure
		{	
			get{ return _SalesCommissionStructure; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_SalesCommissionStructure, value, _SalesCommissionStructure);
				if (PropertyChanging(args))
				{
					_SalesCommissionStructure = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String TechCommissionStructure
		{	
			get{ return _TechCommissionStructure; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_TechCommissionStructure, value, _TechCommissionStructure);
				if (PropertyChanging(args))
				{
					_TechCommissionStructure = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Boolean> RecruitmentProcess
		{	
			get{ return _RecruitmentProcess; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_RecruitmentProcess, value, _RecruitmentProcess);
				if (PropertyChanging(args))
				{
					_RecruitmentProcess = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Boolean> Recruited
		{	
			get{ return _Recruited; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Recruited, value, _Recruited);
				if (PropertyChanging(args))
				{
					_Recruited = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> CreatedDate
		{	
			get{ return _CreatedDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CreatedDate, value, _CreatedDate);
				if (PropertyChanging(args))
				{
					_CreatedDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Status
		{	
			get{ return _Status; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Status, value, _Status);
				if (PropertyChanging(args))
				{
					_Status = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String LastUpdatedBy
		{	
			get{ return _LastUpdatedBy; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_LastUpdatedBy, value, _LastUpdatedBy);
				if (PropertyChanging(args))
				{
					_LastUpdatedBy = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> LastUpdatedDate
		{	
			get{ return _LastUpdatedDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_LastUpdatedDate, value, _LastUpdatedDate);
				if (PropertyChanging(args))
				{
					_LastUpdatedDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  EmployeeBase Clone()
		{
			EmployeeBase newObj = new  EmployeeBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.EmployeeId = this.EmployeeId;						
			newObj.UserId = this.UserId;						
			newObj.Title = this.Title;						
			newObj.FirstName = this.FirstName;						
			newObj.LastName = this.LastName;						
			newObj.Email = this.Email;						
			newObj.Street = this.Street;						
			newObj.City = this.City;						
			newObj.State = this.State;						
			newObj.ZipCode = this.ZipCode;						
			newObj.Country = this.Country;						
			newObj.Phone = this.Phone;						
			newObj.SSN = this.SSN;						
			newObj.IsActive = this.IsActive;						
			newObj.IsDeleted = this.IsDeleted;						
			newObj.IsInstaller = this.IsInstaller;						
			newObj.IsSalesPerson = this.IsSalesPerson;						
			newObj.IsServiceCall = this.IsServiceCall;						
			newObj.HireDate = this.HireDate;						
			newObj.ProfilePicture = this.ProfilePicture;						
			newObj.Session = this.Session;						
			newObj.JobTitle = this.JobTitle;						
			newObj.PlaceOfBirth = this.PlaceOfBirth;						
			newObj.SalesCommissionStructure = this.SalesCommissionStructure;						
			newObj.TechCommissionStructure = this.TechCommissionStructure;						
			newObj.RecruitmentProcess = this.RecruitmentProcess;						
			newObj.Recruited = this.Recruited;						
			newObj.CreatedDate = this.CreatedDate;						
			newObj.Status = this.Status;						
			newObj.LastUpdatedBy = this.LastUpdatedBy;						
			newObj.LastUpdatedDate = this.LastUpdatedDate;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(EmployeeBase.Property_Id, Id);				
			info.AddValue(EmployeeBase.Property_EmployeeId, EmployeeId);				
			info.AddValue(EmployeeBase.Property_UserId, UserId);				
			info.AddValue(EmployeeBase.Property_Title, Title);				
			info.AddValue(EmployeeBase.Property_FirstName, FirstName);				
			info.AddValue(EmployeeBase.Property_LastName, LastName);				
			info.AddValue(EmployeeBase.Property_Email, Email);				
			info.AddValue(EmployeeBase.Property_Street, Street);				
			info.AddValue(EmployeeBase.Property_City, City);				
			info.AddValue(EmployeeBase.Property_State, State);				
			info.AddValue(EmployeeBase.Property_ZipCode, ZipCode);				
			info.AddValue(EmployeeBase.Property_Country, Country);				
			info.AddValue(EmployeeBase.Property_Phone, Phone);				
			info.AddValue(EmployeeBase.Property_SSN, SSN);				
			info.AddValue(EmployeeBase.Property_IsActive, IsActive);				
			info.AddValue(EmployeeBase.Property_IsDeleted, IsDeleted);				
			info.AddValue(EmployeeBase.Property_IsInstaller, IsInstaller);				
			info.AddValue(EmployeeBase.Property_IsSalesPerson, IsSalesPerson);				
			info.AddValue(EmployeeBase.Property_IsServiceCall, IsServiceCall);				
			info.AddValue(EmployeeBase.Property_HireDate, HireDate);				
			info.AddValue(EmployeeBase.Property_ProfilePicture, ProfilePicture);				
			info.AddValue(EmployeeBase.Property_Session, Session);				
			info.AddValue(EmployeeBase.Property_JobTitle, JobTitle);				
			info.AddValue(EmployeeBase.Property_PlaceOfBirth, PlaceOfBirth);				
			info.AddValue(EmployeeBase.Property_SalesCommissionStructure, SalesCommissionStructure);				
			info.AddValue(EmployeeBase.Property_TechCommissionStructure, TechCommissionStructure);				
			info.AddValue(EmployeeBase.Property_RecruitmentProcess, RecruitmentProcess);				
			info.AddValue(EmployeeBase.Property_Recruited, Recruited);				
			info.AddValue(EmployeeBase.Property_CreatedDate, CreatedDate);				
			info.AddValue(EmployeeBase.Property_Status, Status);				
			info.AddValue(EmployeeBase.Property_LastUpdatedBy, LastUpdatedBy);				
			info.AddValue(EmployeeBase.Property_LastUpdatedDate, LastUpdatedDate);				
		}
		#endregion

		
	}
}

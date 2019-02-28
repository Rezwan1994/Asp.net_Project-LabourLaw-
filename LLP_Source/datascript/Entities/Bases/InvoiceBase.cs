using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;

namespace LLP.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "InvoiceBase", Namespace = "http://www.piistech.com//entities")]
	public class InvoiceBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			InvoiceId = 1,
			CustomerId = 2,
			CompanyId = 3,
			Amount = 4,
			Tax = 5,
			DiscountCode = 6,
			DiscountAmount = 7,
			TotalAmount = 8,
			Status = 9,
			InvoiceDate = 10,
			CreatedDate = 11,
			CreatedBy = 12,
			IsEstimate = 13,
			IsBill = 14,
			BillingAddress = 15,
			DueDate = 16,
			Terms = 17,
			ShippingAddress = 18,
			ShippingVia = 19,
			ShippingDate = 20,
			TrackingNo = 21,
			ShippingCost = 22,
			Discountpercent = 23,
			BalanceDue = 24,
			Deposit = 25,
			Message = 26,
			TaxType = 27,
			LastUpdatedDate = 28,
			Balance = 29,
			Memo = 30,
			InvoiceFor = 31,
			LateFee = 32,
			LateAmount = 33,
			InstallDate = 34,
			Description = 35,
			DiscountType = 36,
			BillingCycle = 37
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_InvoiceId = "InvoiceId";		            
		public const string Property_CustomerId = "CustomerId";		            
		public const string Property_CompanyId = "CompanyId";		            
		public const string Property_Amount = "Amount";		            
		public const string Property_Tax = "Tax";		            
		public const string Property_DiscountCode = "DiscountCode";		            
		public const string Property_DiscountAmount = "DiscountAmount";		            
		public const string Property_TotalAmount = "TotalAmount";		            
		public const string Property_Status = "Status";		            
		public const string Property_InvoiceDate = "InvoiceDate";		            
		public const string Property_CreatedDate = "CreatedDate";		            
		public const string Property_CreatedBy = "CreatedBy";		            
		public const string Property_IsEstimate = "IsEstimate";		            
		public const string Property_IsBill = "IsBill";		            
		public const string Property_BillingAddress = "BillingAddress";		            
		public const string Property_DueDate = "DueDate";		            
		public const string Property_Terms = "Terms";		            
		public const string Property_ShippingAddress = "ShippingAddress";		            
		public const string Property_ShippingVia = "ShippingVia";		            
		public const string Property_ShippingDate = "ShippingDate";		            
		public const string Property_TrackingNo = "TrackingNo";		            
		public const string Property_ShippingCost = "ShippingCost";		            
		public const string Property_Discountpercent = "Discountpercent";		            
		public const string Property_BalanceDue = "BalanceDue";		            
		public const string Property_Deposit = "Deposit";		            
		public const string Property_Message = "Message";		            
		public const string Property_TaxType = "TaxType";		            
		public const string Property_LastUpdatedDate = "LastUpdatedDate";		            
		public const string Property_Balance = "Balance";		            
		public const string Property_Memo = "Memo";		            
		public const string Property_InvoiceFor = "InvoiceFor";		            
		public const string Property_LateFee = "LateFee";		            
		public const string Property_LateAmount = "LateAmount";		            
		public const string Property_InstallDate = "InstallDate";		            
		public const string Property_Description = "Description";		            
		public const string Property_DiscountType = "DiscountType";		            
		public const string Property_BillingCycle = "BillingCycle";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private String _InvoiceId;	            
		private Guid _CustomerId;	            
		private Guid _CompanyId;	            
		private Double _Amount;	            
		private Nullable<Double> _Tax;	            
		private String _DiscountCode;	            
		private Nullable<Double> _DiscountAmount;	            
		private Nullable<Double> _TotalAmount;	            
		private String _Status;	            
		private Nullable<DateTime> _InvoiceDate;	            
		private DateTime _CreatedDate;	            
		private String _CreatedBy;	            
		private Boolean _IsEstimate;	            
		private Nullable<Boolean> _IsBill;	            
		private String _BillingAddress;	            
		private Nullable<DateTime> _DueDate;	            
		private String _Terms;	            
		private String _ShippingAddress;	            
		private String _ShippingVia;	            
		private Nullable<DateTime> _ShippingDate;	            
		private String _TrackingNo;	            
		private Nullable<Double> _ShippingCost;	            
		private Nullable<Double> _Discountpercent;	            
		private Nullable<Double> _BalanceDue;	            
		private Nullable<Double> _Deposit;	            
		private String _Message;	            
		private String _TaxType;	            
		private Nullable<DateTime> _LastUpdatedDate;	            
		private Nullable<Double> _Balance;	            
		private String _Memo;	            
		private String _InvoiceFor;	            
		private Nullable<Double> _LateFee;	            
		private Nullable<Double> _LateAmount;	            
		private Nullable<DateTime> _InstallDate;	            
		private String _Description;	            
		private String _DiscountType;	            
		private String _BillingCycle;	            
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
		public String InvoiceId
		{	
			get{ return _InvoiceId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_InvoiceId, value, _InvoiceId);
				if (PropertyChanging(args))
				{
					_InvoiceId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Guid CustomerId
		{	
			get{ return _CustomerId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CustomerId, value, _CustomerId);
				if (PropertyChanging(args))
				{
					_CustomerId = value;
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
		public Double Amount
		{	
			get{ return _Amount; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Amount, value, _Amount);
				if (PropertyChanging(args))
				{
					_Amount = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> Tax
		{	
			get{ return _Tax; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Tax, value, _Tax);
				if (PropertyChanging(args))
				{
					_Tax = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String DiscountCode
		{	
			get{ return _DiscountCode; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_DiscountCode, value, _DiscountCode);
				if (PropertyChanging(args))
				{
					_DiscountCode = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> DiscountAmount
		{	
			get{ return _DiscountAmount; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_DiscountAmount, value, _DiscountAmount);
				if (PropertyChanging(args))
				{
					_DiscountAmount = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> TotalAmount
		{	
			get{ return _TotalAmount; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_TotalAmount, value, _TotalAmount);
				if (PropertyChanging(args))
				{
					_TotalAmount = value;
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
		public Nullable<DateTime> InvoiceDate
		{	
			get{ return _InvoiceDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_InvoiceDate, value, _InvoiceDate);
				if (PropertyChanging(args))
				{
					_InvoiceDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public DateTime CreatedDate
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
		public String CreatedBy
		{	
			get{ return _CreatedBy; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CreatedBy, value, _CreatedBy);
				if (PropertyChanging(args))
				{
					_CreatedBy = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Boolean IsEstimate
		{	
			get{ return _IsEstimate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsEstimate, value, _IsEstimate);
				if (PropertyChanging(args))
				{
					_IsEstimate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Boolean> IsBill
		{	
			get{ return _IsBill; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsBill, value, _IsBill);
				if (PropertyChanging(args))
				{
					_IsBill = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String BillingAddress
		{	
			get{ return _BillingAddress; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_BillingAddress, value, _BillingAddress);
				if (PropertyChanging(args))
				{
					_BillingAddress = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> DueDate
		{	
			get{ return _DueDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_DueDate, value, _DueDate);
				if (PropertyChanging(args))
				{
					_DueDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Terms
		{	
			get{ return _Terms; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Terms, value, _Terms);
				if (PropertyChanging(args))
				{
					_Terms = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String ShippingAddress
		{	
			get{ return _ShippingAddress; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ShippingAddress, value, _ShippingAddress);
				if (PropertyChanging(args))
				{
					_ShippingAddress = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String ShippingVia
		{	
			get{ return _ShippingVia; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ShippingVia, value, _ShippingVia);
				if (PropertyChanging(args))
				{
					_ShippingVia = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> ShippingDate
		{	
			get{ return _ShippingDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ShippingDate, value, _ShippingDate);
				if (PropertyChanging(args))
				{
					_ShippingDate = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String TrackingNo
		{	
			get{ return _TrackingNo; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_TrackingNo, value, _TrackingNo);
				if (PropertyChanging(args))
				{
					_TrackingNo = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> ShippingCost
		{	
			get{ return _ShippingCost; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ShippingCost, value, _ShippingCost);
				if (PropertyChanging(args))
				{
					_ShippingCost = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> Discountpercent
		{	
			get{ return _Discountpercent; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Discountpercent, value, _Discountpercent);
				if (PropertyChanging(args))
				{
					_Discountpercent = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> BalanceDue
		{	
			get{ return _BalanceDue; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_BalanceDue, value, _BalanceDue);
				if (PropertyChanging(args))
				{
					_BalanceDue = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> Deposit
		{	
			get{ return _Deposit; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Deposit, value, _Deposit);
				if (PropertyChanging(args))
				{
					_Deposit = value;
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
		public String TaxType
		{	
			get{ return _TaxType; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_TaxType, value, _TaxType);
				if (PropertyChanging(args))
				{
					_TaxType = value;
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

		[DataMember]
		public Nullable<Double> Balance
		{	
			get{ return _Balance; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Balance, value, _Balance);
				if (PropertyChanging(args))
				{
					_Balance = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String Memo
		{	
			get{ return _Memo; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Memo, value, _Memo);
				if (PropertyChanging(args))
				{
					_Memo = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String InvoiceFor
		{	
			get{ return _InvoiceFor; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_InvoiceFor, value, _InvoiceFor);
				if (PropertyChanging(args))
				{
					_InvoiceFor = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> LateFee
		{	
			get{ return _LateFee; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_LateFee, value, _LateFee);
				if (PropertyChanging(args))
				{
					_LateFee = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<Double> LateAmount
		{	
			get{ return _LateAmount; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_LateAmount, value, _LateAmount);
				if (PropertyChanging(args))
				{
					_LateAmount = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Nullable<DateTime> InstallDate
		{	
			get{ return _InstallDate; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_InstallDate, value, _InstallDate);
				if (PropertyChanging(args))
				{
					_InstallDate = value;
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

		[DataMember]
		public String DiscountType
		{	
			get{ return _DiscountType; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_DiscountType, value, _DiscountType);
				if (PropertyChanging(args))
				{
					_DiscountType = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String BillingCycle
		{	
			get{ return _BillingCycle; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_BillingCycle, value, _BillingCycle);
				if (PropertyChanging(args))
				{
					_BillingCycle = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  InvoiceBase Clone()
		{
			InvoiceBase newObj = new  InvoiceBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.InvoiceId = this.InvoiceId;						
			newObj.CustomerId = this.CustomerId;						
			newObj.CompanyId = this.CompanyId;						
			newObj.Amount = this.Amount;						
			newObj.Tax = this.Tax;						
			newObj.DiscountCode = this.DiscountCode;						
			newObj.DiscountAmount = this.DiscountAmount;						
			newObj.TotalAmount = this.TotalAmount;						
			newObj.Status = this.Status;						
			newObj.InvoiceDate = this.InvoiceDate;						
			newObj.CreatedDate = this.CreatedDate;						
			newObj.CreatedBy = this.CreatedBy;						
			newObj.IsEstimate = this.IsEstimate;						
			newObj.IsBill = this.IsBill;						
			newObj.BillingAddress = this.BillingAddress;						
			newObj.DueDate = this.DueDate;						
			newObj.Terms = this.Terms;						
			newObj.ShippingAddress = this.ShippingAddress;						
			newObj.ShippingVia = this.ShippingVia;						
			newObj.ShippingDate = this.ShippingDate;						
			newObj.TrackingNo = this.TrackingNo;						
			newObj.ShippingCost = this.ShippingCost;						
			newObj.Discountpercent = this.Discountpercent;						
			newObj.BalanceDue = this.BalanceDue;						
			newObj.Deposit = this.Deposit;						
			newObj.Message = this.Message;						
			newObj.TaxType = this.TaxType;						
			newObj.LastUpdatedDate = this.LastUpdatedDate;						
			newObj.Balance = this.Balance;						
			newObj.Memo = this.Memo;						
			newObj.InvoiceFor = this.InvoiceFor;						
			newObj.LateFee = this.LateFee;						
			newObj.LateAmount = this.LateAmount;						
			newObj.InstallDate = this.InstallDate;						
			newObj.Description = this.Description;						
			newObj.DiscountType = this.DiscountType;						
			newObj.BillingCycle = this.BillingCycle;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(InvoiceBase.Property_Id, Id);				
			info.AddValue(InvoiceBase.Property_InvoiceId, InvoiceId);				
			info.AddValue(InvoiceBase.Property_CustomerId, CustomerId);				
			info.AddValue(InvoiceBase.Property_CompanyId, CompanyId);				
			info.AddValue(InvoiceBase.Property_Amount, Amount);				
			info.AddValue(InvoiceBase.Property_Tax, Tax);				
			info.AddValue(InvoiceBase.Property_DiscountCode, DiscountCode);				
			info.AddValue(InvoiceBase.Property_DiscountAmount, DiscountAmount);				
			info.AddValue(InvoiceBase.Property_TotalAmount, TotalAmount);				
			info.AddValue(InvoiceBase.Property_Status, Status);				
			info.AddValue(InvoiceBase.Property_InvoiceDate, InvoiceDate);				
			info.AddValue(InvoiceBase.Property_CreatedDate, CreatedDate);				
			info.AddValue(InvoiceBase.Property_CreatedBy, CreatedBy);				
			info.AddValue(InvoiceBase.Property_IsEstimate, IsEstimate);				
			info.AddValue(InvoiceBase.Property_IsBill, IsBill);				
			info.AddValue(InvoiceBase.Property_BillingAddress, BillingAddress);				
			info.AddValue(InvoiceBase.Property_DueDate, DueDate);				
			info.AddValue(InvoiceBase.Property_Terms, Terms);				
			info.AddValue(InvoiceBase.Property_ShippingAddress, ShippingAddress);				
			info.AddValue(InvoiceBase.Property_ShippingVia, ShippingVia);				
			info.AddValue(InvoiceBase.Property_ShippingDate, ShippingDate);				
			info.AddValue(InvoiceBase.Property_TrackingNo, TrackingNo);				
			info.AddValue(InvoiceBase.Property_ShippingCost, ShippingCost);				
			info.AddValue(InvoiceBase.Property_Discountpercent, Discountpercent);				
			info.AddValue(InvoiceBase.Property_BalanceDue, BalanceDue);				
			info.AddValue(InvoiceBase.Property_Deposit, Deposit);				
			info.AddValue(InvoiceBase.Property_Message, Message);				
			info.AddValue(InvoiceBase.Property_TaxType, TaxType);				
			info.AddValue(InvoiceBase.Property_LastUpdatedDate, LastUpdatedDate);				
			info.AddValue(InvoiceBase.Property_Balance, Balance);				
			info.AddValue(InvoiceBase.Property_Memo, Memo);				
			info.AddValue(InvoiceBase.Property_InvoiceFor, InvoiceFor);				
			info.AddValue(InvoiceBase.Property_LateFee, LateFee);				
			info.AddValue(InvoiceBase.Property_LateAmount, LateAmount);				
			info.AddValue(InvoiceBase.Property_InstallDate, InstallDate);				
			info.AddValue(InvoiceBase.Property_Description, Description);				
			info.AddValue(InvoiceBase.Property_DiscountType, DiscountType);				
			info.AddValue(InvoiceBase.Property_BillingCycle, BillingCycle);				
		}
		#endregion

		
	}
}

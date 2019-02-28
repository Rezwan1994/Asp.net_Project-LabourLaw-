using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;
using LLP.Entities.Bases;
using LLP.Entities.List;

namespace LLP.Entities
{
	[Serializable]
    [DataContract(Name = "ELMAH_Error", Namespace = "http://www.piistech.com//entities")]
	public partial class ELMAH_Error : ELMAH_ErrorBase
	{
		#region Exernal Properties
		#endregion
		
		#region Orverride Equals
		public override bool Equals(Object obj)		
		{
			if (obj.GetType() != typeof(ELMAH_Error))
            {
                return false;
            }			
			
			 ELMAH_Error _paramObj = obj as ELMAH_Error;
            if (_paramObj != null)
            {			
                return (_paramObj.ErrorId == this.ErrorId && _paramObj.CustomPropertyMatch(this));
            }
            else
            {
                return base.Equals(obj);
            }
		}
		#endregion
		
		#region Orverride HashCode
		 public override int GetHashCode()
        {
            return base.ErrorId.GetHashCode();
        }
		#endregion		
	}
}

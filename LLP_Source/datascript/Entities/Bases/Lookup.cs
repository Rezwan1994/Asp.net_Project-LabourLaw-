using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;
using LLP.Entities.Bases;
using LLP.Entities.List;

namespace LLP.Entities
{
	[Serializable]
    [DataContract(Name = "Lookup", Namespace = "http://www.piistech.com//entities")]
	public partial class Lookup : LookupBase
	{
		#region Exernal Properties
		#endregion
		
		#region Orverride Equals
		public override bool Equals(Object obj)		
		{
			if (obj.GetType() != typeof(Lookup))
            {
                return false;
            }			
			
			 Lookup _paramObj = obj as Lookup;
            if (_paramObj != null)
            {			
                return (_paramObj.Id == this.Id && _paramObj.CustomPropertyMatch(this));
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
            return base.Id.GetHashCode();
        }
		#endregion		
	}
}

using System;
using System.Data.SqlClient;

using LLP.Framework;
using LLP.Framework.Exceptions;
using LLP.Entities;
using LLP.Entities.Bases;
using LLP.Entities.List;
using LLP.DataAccess;

namespace LLP.BusinessLogic
{
	/// <summary>
    /// Business logic processing for GlobalSetting.
    /// </summary>    
	public partial class GlobalSettingManager
	{
	
		/// <summary>
        /// Update GlobalSetting Object.
        /// Data manipulation processing for: new, deleted, updated GlobalSetting
        /// </summary>
        /// <param name="globalSettingObject"></param>
        /// <returns></returns>
        public bool Update(GlobalSetting globalSettingObject)
        {
			bool success = false;
			
			success = UpdateBase(globalSettingObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of GlobalSetting Object.
        /// </summary>
        /// <param name="globalSettingObject"></param>
        /// <returns></returns>
        public void FillChilds(GlobalSetting globalSettingObject)
        {
			///Fill external information of Childs of GlobalSettingObject
        }
	}	
}

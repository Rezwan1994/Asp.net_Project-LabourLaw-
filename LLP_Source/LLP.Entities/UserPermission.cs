using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using LLP.Framework;
using LLP.Entities.Bases;
using LLP.Entities.List;

namespace LLP.Entities
{
	public partial class UserPermission 
	{
        public class AdminPermission
        {
            public static int AdminDashboard { get { return 100; } }
        }
        public class User
        {
            public static int UserIndex { get { return 200; } }
        }

    }
}

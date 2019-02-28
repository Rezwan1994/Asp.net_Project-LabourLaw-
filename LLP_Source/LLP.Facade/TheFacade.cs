using LLP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LLP.Facade
{
    public class TheFacade : IDisposable, System.ServiceModel.IExtension<System.ServiceModel.OperationContext>
    {
        private ClientContext _Context;

        public TheFacade(Client client)
        {
            _Context = new ClientContext(client);
        }

        public MailFacade MailFacade
        {
            get
            {
                return (MailFacade)_Context[typeof(MailFacade)];
            }
        }
        public SecurityFacade SecurityFacade
        {
            get
            {
                return (SecurityFacade)_Context[typeof(SecurityFacade)];
            }
        }

        public ChapterFacade ChapterFacade
        {
            get
            {
                return (ChapterFacade)_Context[typeof(ChapterFacade)];
            }
        }
        public ChapterContentFacade ChapterContentFacade
        {
            get
            {
                return (ChapterContentFacade)_Context[typeof(ChapterContentFacade)];
            }
        }
        public UserLoginFacade UserLoginFacade
        {
            get
            {
                return (UserLoginFacade)_Context[typeof(UserLoginFacade)];
            }
        }
        public EmployeeFacade EmployeeFacade
        {
            get
            {
                return (EmployeeFacade)_Context[typeof(EmployeeFacade)];
            }
        }
        public LocalizeResourceFacade ResourceFacade
        {
            get
            {
                return (LocalizeResourceFacade)_Context[typeof(LocalizeResourceFacade)];
            }
        }


        public ChatFacade chatFacade
        {
            get
            {
                return (ChatFacade)_Context[typeof(ChatFacade)];
            }
        }
        public PermissionFacade permissionFacade
        {
            get
            {
                return (PermissionFacade)_Context[typeof(PermissionFacade)];
            }
        }
        public GlobalSettingFacade globalSettingFacade
        {
            get
            {
                return (GlobalSettingFacade)_Context[typeof(GlobalSettingFacade)];
            }
        }

        /// <summary>
        ///  IExtension<OperationContext> Members
        /// </summary>
        /// <param name="owner"></param>
        public void Attach(OperationContext owner) { }

        public void Detach(OperationContext owner) { }

        public void Dispose()
        {
            if (_Context != null)
                _Context.Dispose();

            _Context = null;
        }
    }
}

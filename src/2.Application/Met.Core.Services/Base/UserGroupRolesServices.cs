//--------------------------------------------------------------------
//     此代码由T4模板自动生成
//	   生成时间 2019-01-29 14:23:06 
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//--------------------------------------------------------------------   

using System;
using Met.Core.IServices;
using Met.Core.IRepository;
using Met.Core.Models;

namespace Met.Core.Services
{
    /// <summary>
    /// UserGroupRolesServices
    /// </summary>	
    public partial class UserGroupRolesServices : BaseServices<UserGroupRoles>, IUserGroupRolesServices
    {
	
        IUserGroupRolesRepository dal;
        public UserGroupRolesServices(IUserGroupRolesRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
       
    }
}

	
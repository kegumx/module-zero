﻿using Abp.Authorization.Users;
using Abp.Domain.Entities.Mapping;

namespace Abp.Zero.NHibernate.EntityMappings
{
    public class UserRoleMap : EntityMap<UserRole, long>
    {
        public UserRoleMap()
            : base("AbpUserRoles")
        {
            Map(x => x.UserId);
            Map(x => x.RoleId);
            
            this.MapCreationAudited();
        }
    }
}
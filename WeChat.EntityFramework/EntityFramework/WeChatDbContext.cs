﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MySql.Data.Entity;
using WeChat.Authorization.Roles;
using WeChat.MultiTenancy;
using WeChat.Users;

namespace WeChat.EntityFramework
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WeChatDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WeChatDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WeChatDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WeChatDbContext since ABP automatically handles it.
         */
        public WeChatDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WeChatDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public WeChatDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

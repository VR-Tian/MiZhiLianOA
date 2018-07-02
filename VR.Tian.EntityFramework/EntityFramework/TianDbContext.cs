using System.Data.Common;
using Abp.Zero.EntityFramework;
using VR.Tian.Authorization.Roles;
using VR.Tian.Authorization.Users;
using VR.Tian.MultiTenancy;

namespace VR.Tian.EntityFramework
{
    public class TianDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TianDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TianDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TianDbContext since ABP automatically handles it.
         */
        public TianDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TianDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TianDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

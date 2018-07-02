using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using VR.Tian.EntityFramework;

namespace VR.Tian.Migrator
{
    [DependsOn(typeof(TianDataModule))]
    public class TianMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TianDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
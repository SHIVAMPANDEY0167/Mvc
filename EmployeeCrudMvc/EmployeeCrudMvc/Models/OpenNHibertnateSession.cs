using Microsoft.AspNetCore.Http;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using ISession = NHibernate.ISession;

namespace EmployeeCrudMvc.Models
{
    public class OpenNHibertnateSession
    {
        public static ISession OpenSession()
        {
            string connection = "Server =.; database = EmployeeDbMvc; Integrated Security = SSPI;";
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(connection).ShowSql())
                .Mappings(mapping => mapping.FluentMappings.AddFromAssemblyOf<EmployeeViewModel>())
                .ExposeConfiguration(configuration => new SchemaExport(configuration)
                .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();

            //var configuration = new Configuration();
            //var configurationPath = System.Environment.CurrentDirectory + @"\Models\NHibernate\nhibernateconfiguration.cfg.xml";
            //configuration.Configure(configurationPath);
            //var employeeConfigurationFile = System.Environment.CurrentDirectory + @"\Models\NHibernate\Employeemapping.hbm.xml";
            //configuration.AddFile(employeeConfigurationFile);
            //ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            //return sessionFactory.OpenSession();
        }
    }
}
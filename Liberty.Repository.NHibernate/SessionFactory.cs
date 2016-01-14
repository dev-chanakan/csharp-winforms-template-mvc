using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Liberty.Infrastructure.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;

namespace Liberty.Repository.NHibernate
{
    public static class SessionFactory
    {
        private static ISessionFactory _sessionFactory;

        private static void Initialize()
        {
            var connectionString = "Data Source=.\\sqlexpress;Initial Catalog=Liberty;Integrated Security=True";
            var config = CreateConfiguration(connectionString);
            config.AddAssembly("Liberty.Repository.NHibernate");

            _sessionFactory = config.BuildSessionFactory();
        }

        private static Configuration CreateConfiguration(string connectionString)
        {
            var config = new Configuration();
            config.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
            config.SetProperty("connection.connection_string", connectionString);
            config.SetProperty("adonet.batch_size", "10");
            config.SetProperty("dialect", "NHibernate.Dialect.MsSql2005Dialect");
            config.SetProperty("use_outer_join", "true");
            config.SetProperty("command_timeout", "60");
            config.SetProperty("query.substitutions", "true 1, false 0, yes 'Y', no 'N'");
            config.SetProperty("current_session_context_class", "thread_static");   //For session context
            return config;
        }

        private static ISessionFactory GetSessionFactory()
        {
            if (_sessionFactory == null)
                Initialize();

            return _sessionFactory;
        }

        public static ISession GetNewSession()
        {
            return GetSessionFactory().OpenSession();
        }

        public static ISession GetCurrentSession()
        {
            if (_sessionFactory == null)
            {
                var session = GetNewSession();
                CurrentSessionContext.Bind(session);
            }

            return _sessionFactory.GetCurrentSession();
        }
    }
}

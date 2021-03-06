﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FriendOrganization.UI.Data;
using FriendOrganization.UI.ViewModel;
using FriendOrganizer.DataAccess;

namespace FriendOrganization.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();
            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            return builder.Build();
        }
    }
}

﻿using PrismOutlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutlook.Core;

namespace PrismOutlook.Modules.Mail
{
    public class MailModule : IModule
    {
        public IRegionManager _regionManager { get; }

        public MailModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
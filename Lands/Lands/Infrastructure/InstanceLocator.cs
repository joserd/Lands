﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infrastructure
{
    using ViewsModels;
    
    class InstanceLocator
    {
        #region properties
        public MainViewModel Main

        {
            get;
            set;

        }
        #endregion

        #region constructor
        public InstanceLocator ()

        {
            this.Main = new MainViewModel();

        }

        #endregion
        
    }
}

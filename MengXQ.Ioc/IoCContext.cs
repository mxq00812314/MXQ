﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MengXQ.Ioc
{
    public class IoCContext
    {
        private IoCContext() { }

        private static IoCContext _Context;

        public static IoCContext Context
        {
            get
            {
                if (_Context == null)
                {
                    _Context = new IoCContext();
                }
                return _Context;
            }
        }

        private IDITypeAnalyticalProvider _DITypeAnalyticalProvider;

        public IDITypeAnalyticalProvider DITypeAnalyticalProvider
        {
            get
            {
                if (_DITypeAnalyticalProvider == null)
                {
                    _DITypeAnalyticalProvider = new DefualtDITypeAnalyticalProivder();
                }
                return _DITypeAnalyticalProvider;
            }
            set
            {
                _DITypeAnalyticalProvider = value;
            }
        }

        private DITypeInfoManage _DITypeInfoManage;

        public DITypeInfoManage DITyoeInfoManage
        {
            get
            {
                return _DITypeInfoManage;
            }
            set
            {
                _DITypeInfoManage = value;
            }
        }
    }
}

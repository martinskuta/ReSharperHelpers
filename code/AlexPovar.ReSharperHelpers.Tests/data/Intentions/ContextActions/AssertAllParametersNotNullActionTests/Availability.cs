﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexPovar.ReSharperHelpers.Tests.data.Intentions.ContextActions.AssertAllParametersNotNullActionTests
{
  class Availability
  {
    public void TestMethodA(object obj{off}arg)
    {      
    }
    
    public void TestMethodB(object obj{on}arg, string otherArg)
    {
    }
  }
}
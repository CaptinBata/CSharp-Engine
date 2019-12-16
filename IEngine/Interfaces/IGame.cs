﻿using System;
using System.Collections.Generic;
using System.Text;
using IEngine.Classes;

namespace IEngine.Interfaces
{
    public interface IGame
    {
        List<SFMLObjectBase> SetUpGame(WindowBase renderWindow);
    }
}

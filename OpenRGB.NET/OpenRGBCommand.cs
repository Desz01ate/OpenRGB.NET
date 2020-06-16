﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenRGB.NET
{
    public enum OpenRGBCommand
    {
        RequestControllerCount = 0,
        RequestControllerData = 1,
        SetClientName = 50,
        UpdateLeds = 1050,
        UpdateZoneLeds = 1051,
        UpdateSingleLed = 1052,
        SetCustomMode = 1100,
        UpdateMode = 1101
    }
}

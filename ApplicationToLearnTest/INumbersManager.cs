﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationToLearnTest
{
    public interface INumbersManager
    {
        List<int> SortNumbers(List<int> numbers, bool ascending);
    }
}

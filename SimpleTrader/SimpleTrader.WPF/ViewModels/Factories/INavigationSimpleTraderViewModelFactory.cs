﻿using SimpleTrader.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.WPF.ViewModels.Factories
{
    public interface INavigationSimpleTraderViewModelFactory<T>
    {
        T CreateViewModel(INavigator navigator);
    }
}

﻿using System.Collections.Generic;

namespace HotTips
{
    public interface ITipManager
    {
        List<GroupOfTips>[] GetPrioritizedTipGroups();
    }
}
using System;
using System.IO;
using System.Reflection;
using ICities;
using UnityEngine;

namespace AllAreasUnlockable
{
    public class AllAreasUnlockable : IUserMod
    {
        public string Name
        {
            get { return "All Areas Unlockable @github.com/umuterozan"; }
        }

        public string Description
        {
            get { return "This mode makes all areas on the map unlockable"; }
        }
    }

    public class MaxTilesAreas : AreasExtensionBase
    {
        public override bool OnCanUnlockArea(int x, int z, bool originalResult)
        {
            return true;
        }
        public override void OnCreated(IAreas areas)
        {
            base.OnCreated(areas);
            areas.maxAreaCount = 25;
        }
    }
}

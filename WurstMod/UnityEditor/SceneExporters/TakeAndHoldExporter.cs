﻿using System;
using UnityEngine.SceneManagement;
using WurstMod.MappingComponents.Generic;
using WurstMod.MappingComponents.TakeAndHold;
using WurstMod.Shared;

namespace WurstMod.UnityEditor.SceneExporters
{
    public class TakeAndHoldExporter : SceneExporter
    {
        public override string GamemodeId => Constants.GamemodeTakeAndHold;

        public override void Validate(Scene scene, CustomScene root, ExportErrors err)
        {
            // Base validate
            base.Validate(scene, root, err);

            // Check for all required components
            RequiredComponents<Scoreboard>(1, 1);
            RequiredComponents<Respawn>(1, 1);
            RequiredComponents<TNH_HoldPoint>(2);
            RequiredComponents<TNH_SupplyPoint>(3);
            RequiredComponents<ForcedSpawn>(0, 1);
        }
    }
}
﻿using System;
using System.Numerics;

using Dalamud.Configuration;
using Dalamud.Plugin;

namespace SmartVote
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        [NonSerialized]
        private DalamudPluginInterface pluginInterface;

        public int Version { get; set; }

        public bool Enable { get; set; } = true;
        public bool AutoOpen { get; set; } = true;
        public bool Visible { get; set; } = true;

        public bool NoBackground { get; set; }

        public bool Lock { get; set; }

        public string VoteMode { get; set; } = "partner";

        public Vector4 FontColor { get; set; } = new Vector4(1f, 1f, 0.0f, 1f);

        public string Mode { get; set; } = "partner";

        public void Initialize(DalamudPluginInterface pluginInterface) => this.pluginInterface = pluginInterface;

        public void Save() => this.pluginInterface.SavePluginConfig(this);

        public string ForceSetMvpName { get; set; }

        public void ResetTerritory()
        {
            this.ForceSetMvpName = null;
        }
    }
}

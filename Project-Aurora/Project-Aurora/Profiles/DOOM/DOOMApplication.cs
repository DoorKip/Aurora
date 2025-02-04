﻿using Aurora.Settings.Layers;

namespace Aurora.Profiles.DOOM;

public class DOOM : Application
{
    public DOOM()
        : base(new LightEventConfig {
            Name = "DOOM",
            ID = "doom",
            ProcessNames = new[] { "DOOMx64.exe" , "DOOMx64vk.exe" },
            ProfileType = typeof(WrapperProfile),
            OverviewControlType = typeof(Control_DOOM),
            GameStateType = typeof(GameState_Wrapper),
            IconURI = "Resources/doom_256x256.png"
        })
    {
        AllowLayer<WrapperLightsLayerHandler>();
    }
}
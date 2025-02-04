﻿using Artemis.Core.LayerBrushes;

namespace Artemis.Plugins.Wrappers.Logitech.LayerBrushes
{
    public class LogitechWrapperLayerBrushProvider : LayerBrushProvider
    {
        public override void Enable()
        {
            RegisterLayerBrushDescriptor<LogitechWrapperLayerBrush>("Logitech Grabber Layer", "Allows you to have Logitech Lightsync lighting on all devices.", "Robber");
        }

        public override void Disable()
        {
        }
    }
}

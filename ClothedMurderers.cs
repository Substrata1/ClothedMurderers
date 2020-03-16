using System;
using Oxide.Core;

namespace Oxide.Plugins
{
    [Info("Clothed Murderers", "Substrata", "1.0.0")]
    [Description("Puts the default clothing back on murderer NPCs")]
    class ClothedMurderers : RustPlugin
    {
        void OnEntitySpawned(BaseNetworkable entity)
        {
            if (entity is NPCMurderer)
            {
                var murderer = entity as NPCMurderer;

                murderer.inventory.containerWear.Clear();
                ItemManager.CreateByName("burlap.headwrap", 1, 807624505).MoveToContainer(murderer.inventory.containerWear);
                ItemManager.CreateByName("gloweyes").MoveToContainer(murderer.inventory.containerWear);
                ItemManager.CreateByName("tshirt", 1, 795997221).MoveToContainer(murderer.inventory.containerWear);
                ItemManager.CreateByName("burlap.gloves", 1, 1132774091).MoveToContainer(murderer.inventory.containerWear);
                ItemManager.CreateByName("burlap.trousers", 1, 806966575).MoveToContainer(murderer.inventory.containerWear);
                ItemManager.CreateByName("shoes.boots").MoveToContainer(murderer.inventory.containerWear);
            }
        }
    }
}
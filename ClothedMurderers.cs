using System;
using Oxide.Core;

namespace Oxide.Plugins
{
    [Info("Clothed Murderers", "Substrata", "1.0.0")]
    [Description("Puts the default clothing back on murderer NPCs")]
    class ClothedMurderers : RustPlugin
    {
        void OnEntitySpawned(NPCMurderer murderer)
        {       
                var inv = murderer.inventory.containerWear;

                Item burlap_headwrap = ItemManager.CreateByName("burlap.headwrap", 1, 807624505);
                Item gloweyes = ItemManager.CreateByName("gloweyes");
                Item tshirt = ItemManager.CreateByName("tshirt", 1, 795997221);
                Item burlap_gloves = ItemManager.CreateByName("burlap.gloves", 1, 1132774091);
                Item burlap_trousers = ItemManager.CreateByName("burlap.trousers", 1, 806966575);
                Item boots = ItemManager.CreateByName("shoes.boots");

                murderer.inventory.containerWear.Clear();
                if (burlap_headwrap != null) burlap_headwrap.MoveToContainer(inv);
                if (gloweyes != null) gloweyes.MoveToContainer(inv);
                if (tshirt != null) tshirt.MoveToContainer(inv);
                if (burlap_gloves != null) burlap_gloves.MoveToContainer(inv);
                if (burlap_trousers != null) burlap_trousers.MoveToContainer(inv);
                if (boots != null) boots.MoveToContainer(inv);
        }
    }
}
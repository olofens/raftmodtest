using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[ModTitle("firstmod")]
[ModDescription("Default Mod Description")]
[ModAuthor("ModAuthor")]
[ModVersion("1.0")]
[RaftVersion("1.03")]
public class firstmod : Mod
{

    private ModItem newItem;

    private void Start()
    {
        newItem = ScriptableObject.CreateInstance<ModItem>().Create("WindTurbine", ItemType.Inventory);
        newItem.setInventorySettings("Wind Turbine", "A wind turbine which can be repurposed in several ways.", null, "Item/" + newItem.name, 5);
        RAPI.addItem(newItem);
        RConsole.Log("firstmod loaded!");
    }


    public void Update()
    {
        Network_Player player = RAPI.getLocalPlayer();
    }

    public void OnModUnload()
    {
        RConsole.Log("firstmod has been unloaded!");
        Destroy(gameObject);
    }
}
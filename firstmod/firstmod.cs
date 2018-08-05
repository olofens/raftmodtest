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
    private void Start()
    {
        RConsole.Log("firstmod loaded!");
    }


    public void Update()
    {
        
    }

    public void OnModUnload()
    {
        RConsole.Log("firstmod has been unloaded!");
        Destroy(gameObject);
    }
}
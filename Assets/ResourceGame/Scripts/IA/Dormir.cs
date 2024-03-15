using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormir : State
{
    void Start()
    {
        RandeArray();
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugar : State
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
        if(FrameRate> arrayTime[index])
        {
            FrameRate = 0;
            index++;
            if (index == arrayTime.Length)
                RandeArray();
            index = index % arrayTime.Length;

            m_MachineState.NextState(TypeState.Banno);
        }
        FrameRate += Time.deltaTime; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banno : State
{

    // Start is called before the first frame update
    
    
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
        if (FrameRate > arrayTime[index])
        {
            FrameRate = 0;
            index++;
            if (index == arrayTime.Length)
                RandeArray();
            index = index % arrayTime.Length;

            m_MachineState.NextState(TypeState.Jugar);
        }
        FrameRate += Time.deltaTime;
    }
}

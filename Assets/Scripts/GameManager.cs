using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Wizard wizardP1;
    public Wizard wizardP2;
    
    void Start()
    {
        wizardP1.ClearRunes();
        //wizardP2.ClearRunes();
    }

    void Update()
    {
        
    }
}

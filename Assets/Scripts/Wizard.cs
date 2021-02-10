using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Wizard
{
    public List<Rune> chargedRunes;
    public List<RuneObject> chargedRuneDisplayObjects;

    private int nextFreeIndex = 0;

    public void SetRune(int index, Rune rune)
    {
        chargedRunes[index] = rune;
        chargedRuneDisplayObjects[index].ObjectRune = rune;
    }

    public void AddRune(Rune rune)
    {
        if (nextFreeIndex >= 4)
        {
            return;
        }
        
        SetRune(nextFreeIndex, rune);
        nextFreeIndex++;
    }

    public void ClearRunes()
    {
        for (int i = 0; i < 4; i++)
        {
            chargedRunes[i] = Rune.None;
            chargedRuneDisplayObjects[i].ObjectRune = Rune.None;
        }

        nextFreeIndex = 0;
    }
}

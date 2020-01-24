﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        this.name = "Joey";
    }
    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfor()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }
}

public struct Weapon
{
    public string name;
    public int damage;
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}



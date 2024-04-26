using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Cowboy : Character
{
    public Cowboy(string name) : base(name, 20, Resources.Load<Sprite>("Sprites/cowboy")) // construimos padre
    {
        
    }

    public override float Attack()
    {
        Debug.Log("Cowboy ataca");
        return Random.Range(damage, damage * 1.5f);
    }

    public override float Heal()
    {
        Debug.Log("cowboy se cura");
        health += 10;
        base.Heal();
        return 10;
    }



}

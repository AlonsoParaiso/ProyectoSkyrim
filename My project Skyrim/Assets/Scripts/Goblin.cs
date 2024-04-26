using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Goblin : Character
{
    public Goblin() : base("goblin", 10, Resources.Load<Sprite>("Sprites/goblin")) // construimos padre
    {
       
    }

    public override float Attack()
    {
        Debug.Log("Goblin ataca");
        if (health >= 20)
        {
            return damage;
        }
        else {

            return damage * 3;
        }
    }

    public override float Heal()
    {
        float cure;
        Debug.Log("Goblin se cura");
        cure = damage / 2;
        health += cure;
        base.Heal();
        return cure;
    }
}

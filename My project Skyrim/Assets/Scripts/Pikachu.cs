using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Character
{
    public Pikachu() : base("Pikachu", 15, Resources.Load<Sprite>("Sprites/pikachu")) // construimos padre
    {

    }

    public override float Attack()
    {
        Debug.Log("Pikachu ataca");
        if (health >= 20)
        {
            return damage;
        }
        else
        {

            return 100f;
        }
    }

    public override float Heal()
    {
        float cure;
        Debug.Log("Pikachu se cura");
        cure = damage / 3;
        health += cure;
        base.Heal();
        return cure;
    }
}

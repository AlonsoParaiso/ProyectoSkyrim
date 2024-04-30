using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Wizard : Character
{
    private float damageMultiplayer;

    public Wizard(float damageMultiplayer, string name) : base(name, 15, Resources.Load<Sprite>("Sprites/wizard"))
    {
        this.damageMultiplayer = damageMultiplayer;
    }



    public override float Attack()
    {
        damage *= damageMultiplayer;
        return damage;
    }

    public override float Heal() 
    {
        float cure;
        Debug.Log("Wizard se cura");
        cure = Random.Range(damage, damage * damageMultiplayer);
        health += cure;
        base.Heal();
        return cure;
    }

}

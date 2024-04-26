using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    private string name;
    private Sprite _sprite;
    public float health=100;
    protected float damage;


    public Character()
    {

    }

    public Character(string name, float damage, Sprite sprite)
    {
        this.name = name;
        this.damage = damage;
        _sprite = sprite;
    }

    public string GetName()
    {
        return name;
    }

    public Sprite GetSprite()
    {
        return _sprite;
    }


    public float GetDamage()
    {
        return damage;
    }

    public abstract float Attack();

    public virtual float Heal()
    {
        Debug.Log("Character se cura");
        //if(health > 100)
        //{
        //    return 100;
        //}
        //else if(health < 0)
        //{
        //    return 0;
        //}
        //else
        //{
        //    return health;
        //}
        health = Mathf.Clamp(health, 0, 100);
        return health;
    }
}
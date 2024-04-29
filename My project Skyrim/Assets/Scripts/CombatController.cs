using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public KeyCode attackKey = KeyCode.Mouse0, healKey = KeyCode.Mouse1;
    public float playerAttack;
    public float enemyAttack;
    public Character character, enemy;

    private void Start()
    {
        GetComponent < PlayerMovement >().enabled = false;
    }
    void Update()
    {
        playerAttack += Time.deltaTime;
        enemyAttack += Time.deltaTime;

        if (playerAttack > 5f)
        {
            if (Input.GetKeyDown(attackKey))
            {
                float dmg = GameManager.instance.character.Attack();
                enemy.health -= dmg;
                playerAttack = 0;
            }
            if (Input.GetKeyDown(healKey))
            {
                float vida = GameManager.instance.character.Heal();
                GameManager.instance.character.health += vida;
                playerAttack = 0;
            }
        }
        if (enemyAttack >9f)
        {
            int num = Random.Range(0, 2);
            if (num == 0)
            {
                float dmg = enemy.Attack();
                GameManager.instance.character.health -= dmg;
                enemyAttack = 0;
            }
            if (num == 1)
            {
                float vida = enemy.Heal();
                enemy.health += vida;
                enemyAttack = 0;
            }
        }
        if (enemy.health == 0)
        {
            GetComponent<PlayerMovement>().enabled = true;
            Destroy(this);
        }
    }
}

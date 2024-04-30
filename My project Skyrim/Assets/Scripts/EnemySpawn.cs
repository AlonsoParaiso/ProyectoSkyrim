using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EnemySpawn : MonoBehaviour
{
    private GameObject prefabEnemy;

    private void Awake()
    {
        prefabEnemy = Resources.Load<GameObject>("Prefabs/enemigo");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>() && Random.Range(0, 2) == 1 && !collision.GetComponent<CombatController>())
        {
            //SelectCharacter();
            //Instantiate(enemy, new Vector2((, )  , Quaternion.identity);
            CombatController kC = collision.gameObject.AddComponent<CombatController>();
            SelectCharacter(kC);
            GameObject obj = Instantiate(prefabEnemy, new Vector2(collision.transform.position.x + 5, collision.transform.position.y), Quaternion.identity);
            obj.GetComponent<SpriteRenderer>().sprite = kC.enemy.GetSprite();
        }
    }

    private void SelectCharacter(CombatController combatController)
    {
        int num = Random.Range(0, 2);
        switch (num)
        {
            case 0:
                combatController.enemy = new Pikachu();
                break; 
            case 1:
                combatController.enemy = new Goblin();
                break;
            default:
                combatController.enemy = new Pikachu();
                break;
        }
    }
}

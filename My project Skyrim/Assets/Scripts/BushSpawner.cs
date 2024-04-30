using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushSpawner : MonoBehaviour
{
    public GameObject bush;
    public int width = 3;
    public int height = 3;
    private int num;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = bush.GetComponent<SpriteRenderer>();
        num = Random.Range(-5,5);
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                Instantiate(bush, new Vector2((x+num) * spriteRenderer.bounds.size.x, (y+num) * spriteRenderer.bounds.size.y), Quaternion.identity);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public KeyCode leftKey = KeyCode.A, rightKey = KeyCode.D, upKey = KeyCode.W, downKey = KeyCode.S;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D rb;
    private Vector2 dir;
    
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        _spriteRenderer.sprite = GameManager.instance.character.GetSprite();
    }
        

    // Update is called once per frame
    void Update()
    {
        dir = Vector2.zero;
        // El if pregunta que que tecla estoy pulasndo para mover la basura
        if (Input.GetKey(leftKey) || Input.GetKey(KeyCode.LeftArrow))
        {
            dir = new Vector2(-1, dir.y);
        }
        else if (Input.GetKey(rightKey) || Input.GetKey(KeyCode.RightArrow))
        {
            dir = new Vector2(1, dir.y);
        }
        if (Input.GetKey(upKey) || Input.GetKey(KeyCode.UpArrow))
        {
            dir = new Vector2(dir.x, 1);
        }
        else if (Input.GetKey(downKey) || Input.GetKey(KeyCode.DownArrow))
        {
            dir = new Vector2(dir.x, -1);
        }
    }

    private void FixedUpdate()//velocidad
    {
        rb.velocity = new Vector2(speed, speed) * dir;
    }

    private void OnDisable()
    {
        rb.velocity = Vector2.zero;
    }

}




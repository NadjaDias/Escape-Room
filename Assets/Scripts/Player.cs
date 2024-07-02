using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    public int moveH;
    public int velocidade;
    public int forcaPulo;
    public bool isJumping = false;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    public bool animDobleJump = false;
    public bool hitPlayer = false;
    public int dobleJumping = 0;
    public int vida = 100;
    public int vidas = 3;
    public bool comVida = true;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
     private void FixedUpdate() 
    {
        //Andar
        float moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0 , 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Animação de Andar
        if(Input.GetKey(KeyCode.D) &&  moveH > 0)
        {
            sprite.flipX = false;
        }
        if(Input.GetKey(KeyCode.A) && moveH < 0)
        {
            sprite.flipX = true;
        }

        //Pular
        if(Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * forcaPulo, ForceMode2D.Impulse);
            isJumping = true;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * forcaPulo, ForceMode2D.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
    }
}

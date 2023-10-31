using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manScript : MonoBehaviour
{

    public Rigidbody2D body;
    public float jumpHeight;
    public LogicScript logic;
    public bool isAlive;
    [SerializeField] private AudioSource jumpSound;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) && isAlive) { 
            body.velocity = Vector2.up * jumpHeight;
            animator.SetTrigger("jump");
        } 

        if (transform.position.y < -0.71 || transform.position.y > 0.71) 
        {
            logic.gameOver();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }

    public void playSound()
    {
        jumpSound.Play();
    }
}

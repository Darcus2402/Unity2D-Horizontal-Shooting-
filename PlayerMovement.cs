using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    private Rigidbody2D rb;
    private float horizontalInput;
    [SerializeField] private float Speed;
    [SerializeField] SpriteRenderer spriteRend;
    [SerializeField] private Transform Launcher;
    [SerializeField] GameObject projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        flipSprite();
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(horizontalInput * Speed, 0);
    }


    void flipSprite(){
        if(horizontalInput != 0){
    
            if(horizontalInput > 0){
            Launcher.transform.localPosition = new Vector3(0.5f, 0, 0);
            Launcher.localRotation = Quaternion.Euler(0f, 0f, 0f);
            spriteRend.flipX = false;

            } else if (horizontalInput < 0){
                Launcher.transform.localPosition = new Vector3(-0.5f, 0, 0);
                Launcher.localRotation = Quaternion.Euler(0f, 180f, 0f);
                spriteRend.flipX = true;

            }
        }
    }
}




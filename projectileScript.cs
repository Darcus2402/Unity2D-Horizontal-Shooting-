using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    [SerializeField] private float Speed = 13f;
    [SerializeField] Rigidbody2D rb;



    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * Speed;
    }



    void OnTriggerEnter2D(Collider2D col){
        if(col.name != "Player" && col.tag != "Bullet"){
            Debug.Log(col.name + " " + col.tag);
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerController : MonoBehaviour 
{
    public float speed; 

    private Rigidbody2D rb2;

    void Start ()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2.AddForce(movement * speed);
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.CompareTag("PickUps"))
        {
            other.gameObject.SetActive (false);
        }
    }

}

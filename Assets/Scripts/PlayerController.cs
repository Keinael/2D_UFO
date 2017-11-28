using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using NUnit.Framework.Internal;

public class PlayerController : MonoBehaviour 
{
    public float speed; 

    private Rigidbody2D rb2;
    private int count;
    public Text countText;
    public Text winText;

    void Start ()
    {
        rb2 = GetComponent<Rigidbody2D>();
        count = 0;
        countText.text = "Score: 0";
    }

    void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2.AddForce(movement * speed);
        if (count == 10)
        {
            
        }
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.CompareTag("PickUps"))
        {
            other.gameObject.SetActive (false);
            count++;
            countText.text = "Score: " + count.ToString();
        }
        if (count == 10)
        {
            winText.text = "You win this battle...";
        }
    }

}

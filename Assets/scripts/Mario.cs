using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mario : MonoBehaviour
{
    
    public float speed = 5;
    public int score = 0;
    public float force = 50 ;
   
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce( Vector2.up * force );
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.name.StartsWith("hamburger"))
        {
            score = score + 1;
            Destroy(target.gameObject);
            Debug.Log(score);
        }
    }
}

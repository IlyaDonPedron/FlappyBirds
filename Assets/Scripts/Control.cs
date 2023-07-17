using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public float forwardSpeed;
    public float force;
    Rigidbody2D objectRigid;
    public Text score;
    private int value;

    void Start()
    {
        objectRigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        objectRigid.velocity += new Vector2(forwardSpeed, 0)*Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            objectRigid.velocity=(Vector2.up*force);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            SceneManager.LoadScene(2);
        }

        if (collision.tag == "Obstacle")
        {
            SceneManager.LoadScene(2);
        }

        if (collision.tag == "Bonus")
        {
            value += 1;
            score.text = value.ToString();
            Destroy(collision.gameObject);
        }
    }
    

}

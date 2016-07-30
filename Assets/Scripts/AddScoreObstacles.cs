using UnityEngine;
using System.Collections;

public class AddScoreObstacles : MonoBehaviour {

    bool CollisionWithXuru = false;
    public int addPoint = 10;
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log(collision.collider.gameObject.name);
            if (!CollisionWithXuru && (collision.collider.gameObject.name == "Foot" || collision.collider.gameObject.name == "Foot2"))
            {
                NotificationCenter.DefaultCenter().PostNotification(this, "PlusScore", addPoint);
            CollisionWithXuru = true;
            }
        }

        /*
        if (!CollisionWithXuru  && collision.gameObject.tag == "Player")
        {
            GameObject obj = collision.contacts [0].collider.gameObject;
            if (obj.name== "Foot" || obj.name== "Foot2")
            {
                CollisionWithXuru = true;
            }
            NotificationCenter.DefaultCenter().PostNotification(this, "PlusScore", addPoint);  

        }
        */
    }



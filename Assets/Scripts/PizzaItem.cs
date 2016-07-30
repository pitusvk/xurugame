using UnityEngine;
using System.Collections;

public class PizzaItem : MonoBehaviour {

    public int addPoint = 50;
  

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            GetComponent<AudioSource>().Play();

        NotificationCenter.DefaultCenter().PostNotification(this, "PlusScore", addPoint);

        
        Destroy(gameObject);

      

    }
}

using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public float space = 6f;
    	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x+space, transform.position.y, transform.position.z);

	}
}

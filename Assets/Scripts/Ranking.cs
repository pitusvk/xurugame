using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Ranking : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();

        if (Social.localUser.authenticated)
            
        { ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkI4qbRw4oJEAIQBg");

        } else {
            Social.localUser.Authenticate((bool success) => { });
        
    }

    }
}

using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Logros : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    
        { }

    void OnMouseDown()

    {
            GetComponent<AudioSource>().Play();

            if (Social.localUser.authenticated)

            {
                Social.Active.ShowAchievementsUI();

            }
            else
            {
                Social.localUser.Authenticate((bool success) => { });

            }

        }
}

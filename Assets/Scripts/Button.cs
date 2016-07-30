using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();

       SceneManager.LoadScene("01GameScene");
       
        // Application.Quit();

    }
}

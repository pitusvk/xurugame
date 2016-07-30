using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    public string nameScene = "01GameScene";

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

       SceneManager.LoadScene(nameScene);
       
        // Application.Quit();

    }
}

using UnityEngine;
using System.Collections;

public class CallGameOver : MonoBehaviour {

    public GameObject GameOverCamera;
    public AudioClip SoundGameOver;
   

    // Use this for initialization
    void Start () {

        NotificationCenter.DefaultCenter().AddObserver(this, "XuruisDead");

    }

     void XuruisDead(Notification notificacion)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().clip = SoundGameOver;
        GetComponent<AudioSource>().loop = false;
        GetComponent<AudioSource>().Play();
        GameOverCamera.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

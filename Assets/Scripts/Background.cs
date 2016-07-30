using UnityEngine;
//using System.Collections;

public class Background : MonoBehaviour {

    public bool StartinMovement = false;
    public float movement;
    bool inMovement = false;
    private float StartTime;

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "XuruRunning");
        NotificationCenter.DefaultCenter().AddObserver(this, "XuruisDead");
        if (StartinMovement)
        {
            XuruRunning();
        }

    }

    void XuruisDead()
    {
        inMovement=false;
    }

    void XuruRunning()
    {
        inMovement = true;
        StartTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if(inMovement)
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time -StartTime)*movement, 0);

    }
}

using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject[] obj;
    public float timeMin = 1f;
    public float timeMax = 2f;
    private bool end = false;

	// Use this for initialization
	void Start () {

        NotificationCenter.DefaultCenter().AddObserver(this,"XuruRunning");
        NotificationCenter.DefaultCenter().AddObserver(this, "XuruisDead");

    }

    void XuruisDead()
    {
        end = true;
    }

    void XuruRunning (Notification notificacion ){


        Generar();
        }
    
	
	// Update is called once per frame
	void Update () {
	
	}

    void Generar()
    {
        if (!end) { 
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            Invoke("Generar", Random.Range(timeMin, timeMax));
        }
    }
}

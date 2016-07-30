using UnityEngine;
using System.Collections;

public class InformationGameOver : MonoBehaviour {

    public TextMesh score, record;
     public Score puntuation;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        // Debug.Log("It works!!");
        score.text = puntuation.puntuation.ToString();
        record.text = GameState.estadoJuego.puntuacionMaxima.ToString();
    }
}

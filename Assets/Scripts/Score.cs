using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    private int key = 0;
    private int _puntuation = 0;
    public int puntuation {
        get { return _puntuation ^ key; }
        set { key = Random.Range(0, int.MaxValue);
            _puntuation = value ^ key;
        }
     }
    public TextMesh tableScore;

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "PlusScore");
        NotificationCenter.DefaultCenter().AddObserver(this, "XuruisDead");
        TableScore();

    }

    void XuruisDead(Notification notification)
    {
        if (puntuation > GameState.estadoJuego.puntuacionMaxima)
        { //Debug.Log( "Esta vez si me hiciste correr, puntuacion máxima superada" + GameState.estadoJuego.puntuacionMaxima + "Ahora hicimos" + puntuation);
            GameState.estadoJuego.puntuacionMaxima = puntuation;
            GameState.estadoJuego.Guardar();
        }

        Social.ReportScore(puntuation, "CgkI4qbRw4oJEAIQBg", (bool succes) => { });

        if (puntuation >= 10)
        {
            Social.ReportProgress("CgkI4qbRw4oJEAIQAQ", 100.0, (bool success) => { });       
        }

        if (puntuation >= 100)
        {
            Social.ReportProgress("CgkI4qbRw4oJEAIQAg", 100.0, (bool success) => { });
        }

        if (puntuation >= 200)
        {
            Social.ReportProgress("CgkI4qbRw4oJEAIQAw", 100.0, (bool success) => { });
        }

        if (puntuation >= 300)
        {
            Social.ReportProgress("CgkI4qbRw4oJEAIQBA", 100.0, (bool success) => { });
        }

        if (puntuation >= 400)
        {
            Social.ReportProgress("CgkI4qbRw4oJEAIQBQ", 100.0, (bool success) => { });
        }


    }

    // }else
    //{ Debug.Log( "Sorry, esta ve no pasamos nuestra marca" + GameState.estadoJuego.puntuacionMaxima + "Ahora hicimos" + puntuation); }

    void PlusScore(Notification notification) {
        int points = (int) notification.data;
        puntuation += points;
        Debug.Log("Vamos sumando " + points + " cuchicientos puntos. El total es " + puntuation);
        TableScore();
         }

    void TableScore()
    {
        tableScore.text = puntuation.ToString();
        
    }

	
	// Update is called once per frame
	void Update () {
	
	}
}

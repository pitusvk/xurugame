using UnityEngine;
using System.Collections;

public class XuruController : MonoBehaviour {

    public float jumpForce = 100f;

    public bool inGround = true;
    public Transform checkingGround;
    float radio = 0.07f;
    public LayerMask layerGround;

    private bool jumpTwo = false;

    Animator animator;

    private bool running = false;
    public float velocidad = 10f;

    void Awake()
    {
        animator = GetComponent<Animator>();

    }

    // Use this for initialization

    void Start () {
	
	}

	//se llama cada cierto tiempo, no de forma continua como el update

    void FixedUpdate()
    {

        if (running)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
        }

        GetComponent<Animator>().SetFloat("VelX", GetComponent<Rigidbody2D>().velocity.y);

        inGround = Physics2D.OverlapCircle(checkingGround.position, radio, layerGround);
        animator.SetBool("onGround", inGround);
        if (inGround)
        {
            jumpTwo = false;
        }

        
          /*  if (inGround == false)
            {
                inGround = true;
            }
        */
    }

    
    // Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            if (running)
            {
                if ((inGround || !jumpTwo))
                {
                    GetComponent<AudioSource>().Play();
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
                    //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
                    if (!jumpTwo && !inGround)
                    {
                        jumpTwo = true;
                    }
                }

            }
                else
            {
                running = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "XuruRunning");
            }
            
        }


    }
}


    

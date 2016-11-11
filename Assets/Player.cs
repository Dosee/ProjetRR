using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{


    public int speed = 4; // Vitesse déplacement
    public int jumpPower = 350; // Puissance saut
    private bool canJump = true; // Peut on sauter ?
    Rigidbody body;

    

    // Use this for initialization
    void Start()    
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {





        float checkposx;
        float checkposy;
        float checkposz;
        checkposx = transform.position.x;
        checkposy = transform.position.y;
        checkposz = transform.position.z;

        if (Input.GetKeyUp(KeyCode.Q))
        {
            StartCoroutine(smoothleft());
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            StartCoroutine(smoothright());
        }
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space))
            {
            jump();
            }
            

        




            transform.position += new Vector3(0, 0, 10f * Time.deltaTime);





        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "mur")
        {
            transform.position = new Vector3(0, 2, 0);
        }
    }
    IEnumerator smoothleft()
    {
        Vector3 starpos = transform.position;
        Vector3 Endpos = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z);
        float i = 0;
        while (i < 1)
        {
            transform.position = Vector3.Lerp(starpos, Endpos,Mathf.SmoothStep(0,1,i) );
            i += Time.deltaTime * 7;
            yield return null;

        }
    }
    IEnumerator smoothright()
    {
        Vector3 starpos = transform.position;
        Vector3 Endpos = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
        float i = 0;
        while (i < 1)
        {
            transform.position = Vector3.Lerp(starpos, Endpos, Mathf.SmoothStep(0, 1, i));
            i += Time.deltaTime * 7;
            yield return null;

        }
    }
    void jump()
    {
        body.AddForce(0, jumpPower, 0, ForceMode.Impulse);
        print("coco");
    }
}



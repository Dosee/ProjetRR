using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{


    public int speed = 4; // Vitesse déplacement
    public int jumpPower = 350; // Puissance saut
    private bool canJump = true; // Peut on sauter ?

    

    // Use this for initialization
    void Start()    
    {

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
            if (checkposx != 5)
                transform.position += new Vector3(5, 0, 0);
            
            }
            if (Input.GetKeyUp(KeyCode.Z))
            {
                if (checkposy != 10)
                    transform.position += new Vector3(0, 5, 0);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                if (checkposy != 0)
                    transform.position -= new Vector3(0, 5, 0);
            }

        




            transform.position += new Vector3(0, 0, 5f * Time.deltaTime);





        
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
}

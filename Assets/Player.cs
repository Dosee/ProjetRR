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



        //Déplacement du joueur dasn l'espace(Ici, un cube)
        /* if (Input.GetKey(KeyCode.Q))
         {
             transform.position -= new Vector3(1f * Time.deltaTime, 0, 0);
         }
         if (Input.GetKey(KeyCode.D))
         {
             transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
         }
         if (Input.GetKey(KeyCode.Z))
         {
             transform.position += new Vector3(0, 1f * Time.deltaTime, 0);
         }
         if (Input.GetKey(KeyCode.S))
         {
             transform.position -= new Vector3(0, 1f * Time.deltaTime, 0);
         }
         transform.position += new Vector3(0, 0, 1f * Time.deltaTime); */

        float checkposx;
        float checkposy;
        float checkposz;
        checkposx = transform.position.x;
        checkposy = transform.position.y;
        checkposz = transform.position.z;

        /* if (Input.GetKeyUp(KeyCode.Q))
         {
             if (checkposx != -5)
                 transform.position -= new Vector3(5, 0, 0);

         }
         if (Input.GetKeyUp(KeyCode.D))
         {
             if (checkposx != 5)
                 transform.position += new Vector3(5, 0, 0);
        {
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
         transform.position += new Vector3(0, 0, 5f * Time.deltaTime); */



       


        if (Input.GetKey(KeyCode.Q))
        {
            if (checkposx > -3)
                transform.position -= new Vector3(10f * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (checkposx < 3)
                transform.position += new Vector3(10f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))

        {
            transform.position += new Vector3(0, 100f * Time.deltaTime, 0);
        }



        transform.position += new Vector3(0, 0, 5f * Time.deltaTime);





    }
}

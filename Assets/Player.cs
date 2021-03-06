﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    [SerializeField]
    InfiniteTerrain Inf;
    public int speed = 4; // Vitesse déplacement
    public int jumpPower = 500; // Puissance saut
    private bool canJump = true; // Peut on sauter ?
    Rigidbody body;

    short pos = 0;
    bool free = true;
    public int numberofcoin = 0;
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

        if (Input.GetKeyDown(KeyCode.Q) && pos>-1&&free)
        {
            StartCoroutine(smoothleft());
            pos--;
        }
        if (Input.GetKeyDown(KeyCode.D)&&pos<1&&free)
        {
            StartCoroutine(smoothright());
            pos++;
        }
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        transform.position += new Vector3(0, 0, 15f * Time.deltaTime);

        print(pos);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "mur")
        {
            transform.position = new Vector3(0, 2, 0);
            pos = 0;
            Inf.ResetAll();
        }
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Coin")
        {
            print("tag");
            numberofcoin++;
            Inf.DeleteGold(col.gameObject);
        }
    }
 
    IEnumerator smoothleft()
    {
        free = false;
        Vector3 starpos = transform.position;
        Vector3 Endpos = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z);
        float i = 0;
        while (i < 1)
        {
            transform.position = Vector3.Lerp(starpos, Endpos,Mathf.SmoothStep(0,1,i) );
            i += Time.deltaTime * 15;
            yield return null;

        }
        transform.position = Endpos;
        free = true;
    }
    IEnumerator smoothright()
    {
        free = false;
        Vector3 starpos = transform.position;
        Vector3 Endpos = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
        float i = 0;
        while (i < 1)
        {
            transform.position = Vector3.Lerp(starpos, Endpos, Mathf.SmoothStep(0, 1, i));
            i += Time.deltaTime * 15;
            yield return null;

        }
        transform.position = Endpos;
        free = true;
    }
    void jump()
    {
        body.AddForce(0, jumpPower, 0, ForceMode.Impulse);
    }
}



using UnityEngine;
using System.Collections;

public class Spawncube : MonoBehaviour {

    public GameObject cube;


	// Use this for initialization
	void Start () {

       GameObject coco = (GameObject) Instantiate(cube);
        coco.transform.position = new Vector3(0, 5, 7); 

	}
	
	// Update is called once per frame
	void Update () {
	        
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPistol : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        Debug.Log(anim.enabled);

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("shoot");
            Debug.Log("shoot");
        }
       // else if(Input.GetKeyDown(KeyCode.Tab))

	}
}

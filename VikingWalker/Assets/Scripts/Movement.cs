using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	CharacterController cc;
    // Start is called before the first frame update
    void Start() 
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") / 3;
        float h = Input.GetAxis("Horizontal") / 3; 
	Vector3 direction = transform.forward * v + transform.right * h;
	cc.SimpleMove(direction);
    }
}

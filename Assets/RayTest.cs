using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    public bool somethingInFront;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        somethingInFront = Physics.Raycast(transform.position, fwd, out hit, 1000);
        Debug.DrawLine(transform.position, transform.position + fwd * 2,Color.red);
        
        if(somethingInFront)
            Debug.Log(hit.collider.gameObject.name);
    }
}

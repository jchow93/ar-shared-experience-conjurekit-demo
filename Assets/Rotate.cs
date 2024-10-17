using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Vector3 rotateAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float x;
    float y;
    float z;
    void Update()
    {
        x += Time.deltaTime * 100;
        y += Time.deltaTime * 100;
        z += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(x, y, z);
    }
}

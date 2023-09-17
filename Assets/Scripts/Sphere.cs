using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public string sphereName = "";

    // Start is called before the first frame update
    void Start()
    {
        float randScale = Random.Range(0.5f,2f);
        transform.localScale = new Vector3(randScale,randScale,randScale);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}

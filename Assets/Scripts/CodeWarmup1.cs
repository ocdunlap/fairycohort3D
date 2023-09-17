using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeWarmup1 : MonoBehaviour
{

    [SerializeField] string objName;
    [SerializeField] float speed;
    [SerializeField] float jumpStrength;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(objName);
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0f, jumpStrength, 0f);
        }
    }
}

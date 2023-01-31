using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float speed = 3f;
    GameObject capsule;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.Find("Capsule");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (horizontal > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}

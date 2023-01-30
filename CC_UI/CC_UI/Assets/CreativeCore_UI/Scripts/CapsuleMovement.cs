using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float direction = 1f;
    public float speed = 3f;
    public float timelimit = 30f;
    public float timecount = 0f;
    public float heightlimit = 1f;
    Vector3 current_position;

    void Awake()
    {
        current_position = this.transform.position;
    }

    void FixedUpdate()
    {
        StartCoroutine(Bounce());
    }

    IEnumerator Bounce()
    {
        transform.Translate(0, direction * speed * Time.deltaTime * 1, 0);


        if (transform.position.y > current_position.y + heightlimit)
        {
            direction = -1;
        }
        if (transform.position.y < current_position.y)
        {
            direction = 0;
            timecount = timecount + Time.deltaTime;

            if (timecount > timelimit)
            {
                direction = 1;
                timecount = 0;
            }
        }

        yield return new WaitForSeconds(1);
    }
}

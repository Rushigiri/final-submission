using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public List<Transform> c;
    int i = 0;
    public float spped1;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            transform.position = Vector3.Lerp(transform.position, c[i].position, spped1 * Time.deltaTime);
            if (transform.position == c[i].position)
            {
                i++;
                if (i == c.Count)
                {
                    i = 0;
                }
            }
        }

    }
}

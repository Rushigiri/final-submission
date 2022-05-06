using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public List<Vector3> vector3;
    public Vector3 player = new Vector3(0, 0, 0);
    public Vector3 p1 = new Vector3(12, 0, 12);
    public Vector3 p2 = new Vector3(14, 0, -10);
    public Vector3 p3 = new Vector3(-11, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    ////    if(collision.collider.tag == "Player")
    ////    {
    ////        Debug.Log("collide");
    ////    }
    //}

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButton(0))
        {

        }


    }
}








// transform.position += new Vector3(0f, 0f, -10f) *Time.smoothDeltaTime;
//transform.Rotate(10f,0f,0f);
//transform.localScale += new Vector3(5f,0f,0f)*Time.deltaTime;
//transform.Translate(0f, 0f, 10f*Time.deltaTime,Space.World);
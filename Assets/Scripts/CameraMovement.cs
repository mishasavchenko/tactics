using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Camera camera = null;
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    public float speed = 5.0f;
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0,-speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0,speed * Time.deltaTime,0);
        }


        camera.orthographicSize += 0.1f * Input.mouseScrollDelta.y;
        if (camera.orthographicSize <= 0.5)
        {
            camera.orthographicSize = 0.5f;
        }
    }   
}



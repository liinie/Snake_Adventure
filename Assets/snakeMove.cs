using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeMove : MonoBehaviour
{

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Translate(speed, 0, 0);
        }else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Translate(-speed, 0, 0);
        }else if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.Translate(0, 0, speed);
        }else if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.Translate(0, 0, -speed);
        }
    }
}

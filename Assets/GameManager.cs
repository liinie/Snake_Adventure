using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> snakeBodies;

    public enum Direction {Left, Right, Up, Down};

    public Direction movementDirection = Direction.Right;

    public Direction lastMoveDirection = Direction.Right;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            movementDirection = Direction.Right;
        }else if (Input.GetKeyDown(KeyCode.LeftArrow)){
            movementDirection = Direction.Left;
        }else if (Input.GetKeyDown(KeyCode.UpArrow)){
            movementDirection = Direction.Up;
        }else if (Input.GetKeyDown(KeyCode.DownArrow)){
            movementDirection = Direction.Down;
        }

        var newPosition = snakeBodies[0].transform.position;

        


    }
}

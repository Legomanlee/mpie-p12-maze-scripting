using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float moveZ = 0;
    float moveX = 0;
    float maxAngle = 30;

    bool downArrowPressed = false;
    bool upArrowPressed = false;
    bool rightArrowPressed = false;
    bool leftArrowPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.Euler(0, 0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown (KeyCode.DownArrow)){
            downArrowPressed = true;
        }
        if (Input.GetKeyUp (KeyCode.DownArrow)){
            downArrowPressed = false;
        }

        if (Input.GetKeyDown (KeyCode.UpArrow)){
            upArrowPressed = true;
        }
        if (Input.GetKeyUp (KeyCode.UpArrow)){
            upArrowPressed = false;
        }

        if (Input.GetKeyDown (KeyCode.RightArrow)){
            rightArrowPressed = true;
        }
        if (Input.GetKeyUp (KeyCode.RightArrow)){
            rightArrowPressed = false;
        }

        if (Input.GetKeyDown (KeyCode.LeftArrow)){
            leftArrowPressed = true;
        }
        if (Input.GetKeyUp (KeyCode.LeftArrow)){
            leftArrowPressed = false;
        }

        if (leftArrowPressed && moveZ < maxAngle){
            moveZ = moveZ + (30 * Time.deltaTime);
        }
        if (rightArrowPressed && moveZ > -maxAngle){
            moveZ = moveZ - (30 * Time.deltaTime);
        }
        if (upArrowPressed && moveX < maxAngle){
            moveX = moveX + (30 * Time.deltaTime);
        }
        if (downArrowPressed && moveX > -maxAngle){
            moveX = moveX - (30 * Time.deltaTime);
        }

        transform.rotation = Quaternion.Euler(moveX, 0, moveZ);
    }
}

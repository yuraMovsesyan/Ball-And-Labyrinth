using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthControl : MonoBehaviour
{
    [SerializeField] KeyCode keyLeft, keyRight, keyBack, keyForward, keyUp, keyDown;
    [SerializeField] int speed;

    private KeyCode keyRestart = KeyCode.R, keyNext = KeyCode.Q;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyRight))
            transform.Rotate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(keyLeft))
            transform.Rotate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(keyBack))
            transform.Rotate(Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(keyForward))
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(keyUp))
            transform.Rotate(Vector3.up * speed * Time.deltaTime);

        if (Input.GetKey(keyDown))
            transform.Rotate(Vector3.down * speed * Time.deltaTime);

        if (Input.GetKey(keyRestart))
            LvlManager.Restart();

        if (Input.GetKey(keyNext))
            LvlManager.Next();
    }  
}

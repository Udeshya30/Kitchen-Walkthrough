using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public GameObject mPlayer;
    private float playerSpeed = 2.0f;

    private void Start()
    {
    }

    void Update()
    {
        mPlayer.gameObject.GetComponent<Animator>().SetFloat("speed",0);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            mPlayer.transform.GetComponent<CharacterController>().Move(move * Time.deltaTime * playerSpeed);
            if (move != Vector3.zero)
            {
                mPlayer.gameObject.transform.forward = move;
                mPlayer.gameObject.GetComponent<Animator>().SetFloat("speed", 1);
            }
        }
    }
}

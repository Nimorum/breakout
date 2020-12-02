using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed;
    Rigidbody2D playerRB;
    bool isBallInPlay = false;
    float direction;
    Vector3 directionVector=Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        direction = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && !isBallInPlay)
        {
            GetComponentInChildren<ParticleSystem>().Emit(1);
            isBallInPlay = true;
        }
    }

    private void FixedUpdate()
    {
        ApplyMotion();
    }

    private void ApplyMotion()
    {
        directionVector.x = direction * speed;
        playerRB.velocity = directionVector;
    }

    public void SetBallInPlay(bool ballInPlay)
    {
        isBallInPlay = ballInPlay;
    }
}

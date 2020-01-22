﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBall : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;
    private float thrust;
    public Rigidbody rb;
    Vector3 ballInHand = new Vector3(-0.49f, -0.29f, 0.38f);
    AudioSource grabSound;
    // Start is called before the first frame update

    void Start()
    {
        grabSound = ball.GetComponent<AudioSource>();
        thrust = 50;
    }
    public void GrabBall1()
    {
        grabSound.volume = 0.2f;
        grabSound.Play();
        rb = ball.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        ball.transform.SetParent(myHand.transform);
        ball.transform.localPosition = ballInHand;
 
    }

 
}

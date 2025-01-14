﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class UpdateFlare : MonoBehaviour
{
    public MeshRenderer flareMesh;
    public MeshRenderer nodeMesh;
    private bool isFlareOn;
    private float counter;
    private float flareDuration = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlareOn)
        {
            counter += Time.deltaTime;
            if (counter > flareDuration)
            {
                flareMesh.enabled = false;
                isFlareOn = false;
                counter = 0;
            }
        }
    }

    public void EnableFlare(float duration =1.5f)
    {
        flareDuration = duration;
        flareMesh.enabled = true;
        isFlareOn = true;
    }

}

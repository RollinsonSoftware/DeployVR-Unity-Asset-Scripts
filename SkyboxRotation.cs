using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotation : MonoBehaviour {

    // skybox material that will rotate
    public Skybox skybox;

    // rotation in degrees
    public float rotationDegrees;

    void Awake()
    {
        skybox.material.SetFloat("_Rotation", rotationDegrees);
    }
}

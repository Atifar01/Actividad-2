using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{

    [SerializeField]
    private Vector3 axes;
    public float scaleUnits;

    // Update is called once per frame
    void Update()
    {
        axes = CapsuleMovement.ClampVector(axes);

        transform.localScale += axes * (scaleUnits * Time.deltaTime);
    }
}
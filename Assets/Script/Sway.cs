using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{
    Quaternion originLocalRotation;
    [SerializeField] float xSwayMultiplier = 1.45f;
    [SerializeField] float ySwayMultiplier = 1.45f;

    private void Start()
    {
        originLocalRotation = transform.localRotation;
    }

    private void Update()
    {
        UpdateSway();
    }

    void UpdateSway()
    {
        float t_xLookInput = Input.GetAxis("Mouse X");
        float t_yLookInput = Input.GetAxis("Mouse Y");
        //  Calculate weapon rotation
        Quaternion t_xAngleAdjustement = Quaternion.AngleAxis(-t_xLookInput * xSwayMultiplier, Vector3.up);
        Quaternion t_yAngleAdjustement = Quaternion.AngleAxis(t_yLookInput * ySwayMultiplier, Vector3.right);
        Quaternion t_targetRotation = originLocalRotation * t_xAngleAdjustement * t_yAngleAdjustement;
        //  Rotate towards target rotation
        transform.localRotation = Quaternion.Lerp(transform.localRotation, t_targetRotation, Time.deltaTime * 10f);
    }
}

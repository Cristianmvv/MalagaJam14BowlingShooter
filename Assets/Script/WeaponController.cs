using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{


    [Header("Parametros")]
    public float fireRange = 200;
    public LayerMask hitableLayer;
    public GameObject bulletHolePF;

    Transform cameraPlayerTransform;

    [Header("Sway")]
    Quaternion originLocalRotation;
    [SerializeField] float xSwayMultiplier = 1.45f;
    [SerializeField] float ySwayMultiplier = 1.45f;

    private void Start()
    {
        originLocalRotation = transform.localRotation;
        cameraPlayerTransform = Camera.main.transform;
    }

    private void Update()
    {
        UpdateSway();
        HandleShoot();
    }

    void HandleShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            if (Physics.Raycast(cameraPlayerTransform.position, cameraPlayerTransform.forward, out hit, fireRange, hitableLayer))
            {
                GameObject bulletHoleClone = Instantiate(bulletHolePF, hit.point + hit.normal *0.001f, Quaternion.LookRotation(hit.normal));
                Destroy(bulletHoleClone, 5f);
            }
        }
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

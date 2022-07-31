using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 2.0f;
    [SerializeField] float gravityValue = -9.81f;
    [SerializeField] float jumpHeight = 1.0f;

    [SerializeField] Slider healthSlider;
    [SerializeField] int healt = 100;
    [SerializeField] float healtTick = 0.05f;

    Vector3 playerVelocity;
    private CharacterController controller;
    private bool groundedPlayer;
    Transform cameraTransform;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
        healthSlider.value = healthSlider.maxValue = healt;
    }

    void Update()
    {
        if (!GameManager.Instance.canMove) return;

        healthSlider.value = healt;
        if(healt <=0)GameManager.Instance.playerDeath = true;

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);

        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //}

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            CancelInvoke("HealtUp");
            InvokeRepeating("HealtDown", 0, healtTick);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            CancelInvoke("HealtDown");
            InvokeRepeating("HealtUp", 0, healtTick*1.5f);
        }
    }

    void HealtDown()
    {
        healt--;
    }

    void HealtUp()
    {
        healt++;
        if(healt > 100) healt = 100;
    }

    //IEnumerator HealthDown()
    //{
    //    healt -= 1;
    //    print("HealtDown");
    //    yield return new WaitForSeconds(healtTick);
    //    StartCoroutine(HealthDown());
    //}
    //IEnumerator HealtUp()
    //{
    //    healt += 1;
    //    print("HealtUp");
    //    yield return new WaitForSeconds(healtTick*0.5f);
    //    StartCoroutine(HealtUp());
    //}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackAndFord : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 60f;

    [SerializeField] GameObject Arrow, ball;
    [SerializeField] Slider Slider;

    float timer;
    bool activateArrow, activateSlider;

    private void Start()
    {
        StartCoroutine(LauncherSequencer()); 
    }

    void Update()
    {
        if (activateArrow)
            Arrow.transform.localEulerAngles = new Vector3(-90, Mathf.PingPong(Time.time * rotateSpeed, 60) - 30, 90);

        if (activateSlider)
        {
            Slider.value = Mathf.PingPong(timer, 1);
            timer += Time.deltaTime;
        }

    }

    IEnumerator LauncherSequencer()
    {
        activateArrow = true;

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

        activateArrow = false;
        activateSlider = true;
        timer = 0;

        yield return new WaitForSeconds(0.1f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

        Arrow.SetActive(false);
        Slider.gameObject.SetActive(false);
        ball.GetComponent<Rigidbody>().AddForce(-Vector3.forward * 60,ForceMode.Impulse);
        GameManager.Instance.canMove = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GameObject[] bowllingSpawner, streetSpawner;
    [SerializeField] GameObject endPanel;
    [SerializeField] PlayableDirector timeTable;


    public bool canMove = false;
    public bool equipWeapon = false;
    public bool playerDeath = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    private void Update()
    {
        if (playerDeath)
        {
            endPanel.SetActive(true);
            canMove = false;
        }
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void RunTimetable()
    {
        timeTable.Play();
    }

    public float GetTimelineDuration()
    {
        return (float)timeTable.duration;
    }

    public void ActivateSpawner()
    {
        for (int i = 0; i < bowllingSpawner.Length; i++)
        {
            bowllingSpawner[i].SetActive(true);
        }
    }

    public void ButtonResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ButtonMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}

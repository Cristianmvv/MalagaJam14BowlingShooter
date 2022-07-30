using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GameObject[] bowllingSpawner, streetSpawner;

    public bool canMove = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}

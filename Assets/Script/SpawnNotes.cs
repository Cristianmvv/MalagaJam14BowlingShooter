using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNotes : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    public float tiempoEntreFlechas;

    private void Start()
    {
        InvokeRepeating("SpawnNote", tiempoEntreFlechas, tiempoEntreFlechas);
    }

    public void SpawnNote()
    {
        int randomPoint = (int)Random.Range(0, 4);
        SpawnPoints[randomPoint].GetComponent<NoteSpawner>().SpawnNote();
    }
}

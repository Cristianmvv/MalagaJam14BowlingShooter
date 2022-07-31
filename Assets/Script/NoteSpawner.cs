using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject canvas;
    public GameObject note;
    
    public void SpawnNote()
    {
        GameObject tmp = Instantiate(note, transform.position, Quaternion.identity);
        tmp.transform.SetParent(canvas.transform);
    }

}

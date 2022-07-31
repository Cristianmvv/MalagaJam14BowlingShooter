using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawn : MonoBehaviour
{
    public List<GameObject> Pins;
    public GameObject[] enemy;
    public int[] chance;

    private void Start()
    {
        Invoke("SpawnEnemy", Random.Range(0.5f,2f));
    }

    void SpawnEnemy()
    {
        int counter = 0;
        for (int i = 0; i < chance.Length; i++)
        {
            counter += chance[i];
        }

        int num = Random.Range(0, counter);

        for (int i = 0; i < chance.Length; i++)
        {
            if (num < chance[i])
            {
                if (i == 0 && Pins.Count > 0)
                {
                    Pins[0].transform.position = transform.position;
                    Pins[0].GetComponent<Collider>().enabled = true;
                    Pins[0].GetComponent<NavMeshAgent>().enabled = true;
                    Pins[0].GetComponent<Enemy>().die = false;
                    //hellephant[0].GetComponent<Animator>().Play("Move");
                    Pins.Remove(Pins[0]);
                    break;
                }
                

                Instantiate(enemy[i], transform.position, transform.rotation);
                break;
            }
            num -= chance[i];
        }
        Invoke("SpawnEnemy", Random.Range(5, 10));
    }
}

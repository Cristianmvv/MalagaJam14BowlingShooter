using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    Transform player;
    NavMeshAgent agent;
    public int maxHealth, health;
    public bool die;
    public int score;
    ParticleSystem explosion;
    AudioSource audioSource;
    public GameObject mesh;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        explosion = GetComponentInChildren<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (!die)
            agent.SetDestination(player.position);
    }

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            die = true;
            GetComponent<Animator>().Play("Death");
            agent.SetDestination(transform.position);
            GetComponent<Collider>().enabled = false;
            agent.enabled = false;
            //Invoke("StartSinking", 2);
            explosion.Play();
            audioSource.Play();
            mesh.SetActive(false);
            Invoke("OnDestroyInvoke", 1.2f);
        }
    }

    private void OnDestroyInvoke()
    {
        Destroy(gameObject);
    }

    public void StartSinking()
    {
        StartCoroutine(Sinking());
    }

    IEnumerator Sinking()
    {
        for (int i = 0; i < 100; i++)
        {
            transform.Translate(Vector3.down * 0.01f);
            yield return new WaitForSeconds(0.05f);
        }
        Destroy(gameObject);   
    }
}


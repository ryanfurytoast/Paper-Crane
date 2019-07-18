using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] int scorePerHit = 25;

    scoreBoard sb;

    // Start is called before the first frame update
    void Start()
    {
        deathFX.SetActive(false);
        sb = FindObjectOfType<scoreBoard>();
    }

    void OnParticelCollision(GameObject other)
    {
        Destroy(gameObject);
        Instantiate(deathFX, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleCollision(GameObject other)
    {
        sb.ScoreHit(scorePerHit);
        Destroy(gameObject);
        Instantiate(deathFX, transform.position, Quaternion.identity);
    }
}

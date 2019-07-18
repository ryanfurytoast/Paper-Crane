using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem deathFX;
    [SerializeField] int scorePerHit;

    scoreBoard sb;

    // Start is called before the first frame update
    void Start()
    {
        sb = FindObjectOfType<scoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleCollision (GameObject other)
    {
        sb.ScoreHit(scorePerHit);
        Destroy(gameObject);
        Instantiate(deathFX, transform.position, Quaternion.identity);
    }
}

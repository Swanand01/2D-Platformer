using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private AudioSource levelCompleteAudio;
    void Start()
    {
        levelCompleteAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            levelCompleteAudio.Play();
            //collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
            collision.gameObject.GetComponent<Animator>().SetInteger("state", 0);
        }
    }
}

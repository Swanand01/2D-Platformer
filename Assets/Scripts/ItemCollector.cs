using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int cherries = 0;
    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectAudio;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Cherry")){
            collectAudio.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }
    }
}

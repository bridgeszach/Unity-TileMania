using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinSFX;
    [SerializeField] int gemValue = 100;

    // Cached References
    AudioSource myAudio;

    private void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(gemValue);
        AudioSource.PlayClipAtPoint(coinSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}

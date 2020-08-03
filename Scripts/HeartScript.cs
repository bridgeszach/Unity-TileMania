using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    [SerializeField] AudioClip heartSFX;
    int heartValue = 1;

    AudioSource myAudio;

    private void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddLife(heartValue);

        AudioSource.PlayClipAtPoint(heartSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}

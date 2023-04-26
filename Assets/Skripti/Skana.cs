using UnityEngine;
using UnityEngine.UI;

public class Skana : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void KlilskaSkana()
    {
        audioSource.Play();
    }
}
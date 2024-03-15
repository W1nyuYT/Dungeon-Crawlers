using UnityEngine;

public class Apple : MonoBehaviour
{
    // Audio clip to loop
    public AudioClip audioClip;

    // Volume of the audio clip
    [Range(0f, 100f)]
    public float volume = 100f;

    // Reference to the audio source component
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Set the audio clip to loop
        audioSource.clip = audioClip;

        // Enable looping
        audioSource.loop = true;

        // Set the volume
        audioSource.volume = volume / 100f;

        // Start playing the audio clip
        audioSource.Play();
    }
}

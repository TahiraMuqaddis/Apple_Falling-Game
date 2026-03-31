using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip music;
    private static MusicManager instance;
    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = music;
            audioSource.loop = true;
            audioSource.volume = 0.3f;
            audioSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

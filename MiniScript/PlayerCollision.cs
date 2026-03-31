using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip hitSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            audioSource.PlayOneShot(hitSound);

            Invoke("LoadGameOver", 0.5f); // delay so sound plays
        }
    }

    void LoadGameOver()
    {
        SceneManager.LoadScene("FinalScene");
    }
}
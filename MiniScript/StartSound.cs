using UnityEngine;

public class StartSound : MonoBehaviour
{
    public AudioClip startSound;

    void Start()
    {
        AudioSource.PlayClipAtPoint(startSound, Camera.main.transform.position);
    }
}
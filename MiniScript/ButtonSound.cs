using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioClip clickSound;

    public void PlaySound()
    {
        AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
     public void StartGame()
     {
        SceneManager.LoadSceneAsync(2);
     }
}

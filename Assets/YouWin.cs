using UnityEngine;
using UnityEngine.SceneManagement;
public class YouWin : MonoBehaviour
{
    public void RestartGame(){
        SceneManager.LoadSceneAsync(1);
    }
}
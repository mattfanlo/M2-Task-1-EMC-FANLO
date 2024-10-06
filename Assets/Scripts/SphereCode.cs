using UnityEngine.SceneManagement;
using UnityEngine;

public class SphereCode : MonoBehaviour
{
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other) 
    {
        
        Debug.Log("You win");
        SceneManager.LoadSceneAsync(3);   
    }


}

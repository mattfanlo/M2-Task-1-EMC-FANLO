using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CubeCollision : MonoBehaviour
{
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("You Lose - You chose box");   
        SceneManager.LoadSceneAsync(2);
    }


}

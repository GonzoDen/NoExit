using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit4Controller : MonoBehaviour
{    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Rabotaet");
            SceneManager.LoadScene(1);

        }
         
    }

}
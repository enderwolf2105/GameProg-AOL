using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishBean : MonoBehaviour
{
    public static FinishBean instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

       // private void Awake()
      //  {
      //      if (instance == null)
     //       {
   //         instance = this;
 //           DontDestroyOnLoad(gameObject);

      //      }
      //      else
      //      {
     //       Destroy(gameObject);
     //    }
    //    }

    
}

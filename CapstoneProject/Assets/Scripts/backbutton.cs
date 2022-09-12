using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public GameObject closeWindow;

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){

            if(SceneManager.GetActiveScene().buildIndex==0){

                closeWindow.SetActive(true);
            }
            else{
                SceneManager.LoadScene(0);
            }
        }
    }
}

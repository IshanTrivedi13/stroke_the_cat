using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Color_LvltoQn : MonoBehaviour
{
    // Start is called before the first frame update
    public void Continue()
    {
        SceneManager.LoadScene("Color_qn");
        Debug.Log("sceneswitch");
    }

    // Update is called once per frame
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Color_mainmenu_level_sel : MonoBehaviour
{
    public void Lvl1()
    {
        SceneManager.LoadScene("Color_level1");
        Debug.Log("sceneswitch");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("Color_level2");
        Debug.Log("sceneswitch");
    }
    public void Lvl3()
    {
        SceneManager.LoadScene("Color_level3");
        Debug.Log("sceneswitch");
    }
    public void Lvl4()
    {
        SceneManager.LoadScene("Color_level4");
        Debug.Log("sceneswitch");
    }
    public void Lvl5()
    {
        SceneManager.LoadScene("Color_level5");
        Debug.Log("sceneswitch");
    }
}

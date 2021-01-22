using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public void LoadScene(int Level)
    {
        SceneManager.LoadScene(Level);
    }
    public void exit()
    {
        Application.Quit();
    }
}

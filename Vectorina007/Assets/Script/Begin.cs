using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{

    public int buildindex;
    public void Levelss()
    {
        SceneManager.LoadScene(buildindex);


    }
}

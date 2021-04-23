using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public int buildindex;
    public void Levelss()
    {
        SceneManager.LoadScene(buildindex);

    }
}

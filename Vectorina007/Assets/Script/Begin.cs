using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public InputField Name;
    public int buildindex;
    public void Levelss()
    {
        //SceneManager.LoadScene(buildindex);


        try
        {

            string a = (Name.text);
            print(a);


        }
        catch (Exception)
        {
            Name.text = "Wrong Value";

        }
    }
}

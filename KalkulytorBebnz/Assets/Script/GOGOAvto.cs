using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOGOAvto : MonoBehaviour
{
    public GameObject Perehod;
    public void Pause007()
    {
        Perehod.SetActive(!Perehod.activeSelf);
    }
}

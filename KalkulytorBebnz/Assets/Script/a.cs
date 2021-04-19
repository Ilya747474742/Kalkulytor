using System;
using UnityEngine;
using UnityEngine.UI;


public class a : MonoBehaviour
{
    public InputField KM;
    public InputField Km100;
    public InputField prise;
    public InputField KolVo;
    public Text Finish;
    public Text Finish1;
    public Text Finish2;
    float d;
    string f;
    float G;
    string g;
    float K;
    string k;
    public void OnEnd() 
    {
        try {
            
            float a = float.Parse(KM.text);
            float b = float.Parse(Km100.text);
            float c = float.Parse(prise.text);
            float n = float.Parse(KolVo.text);

            //print(a);
            //print(b);
            //print(c);
            d = (b/100)*a;
            G = c * d;
            K = G / n;
            string f = d.ToString();
            string g = G.ToString();
            string k = K.ToString();


            Finish.text += d;
            Finish1.text += G;
            Finish2.text += K;


            print(d);
            print(G);
        }
        catch (Exception)
        {
            KM.text = "Wrong Value";

        }
        
    }
  
}

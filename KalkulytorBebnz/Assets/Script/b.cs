using System;
using UnityEngine;
using UnityEngine.UI;

public class b : MonoBehaviour
{
    public InputField KM;
    public InputField Shina;
    public Text Finish;
    public Text Finish1;

    public void OnEnd()
    {
        try
        {

            float a = float.Parse(KM.text);
            float b = float.Parse(Shina.text);


            if (a >= 500000 || a >= 450000 )
            {
                Finish1.text += "Вам пезда";
            }
            if (a <= 20000 )
            {
                Finish1.text += "Машина в новом состоянии";
            }
            if (a <= 100000 && a >= 20001)
            {
                Finish1.text += "Машина в хорошем состоянии";
            }
            if (a <= 250000 && a >= 100001)
            {
                Finish1.text += "Машина в нормальном состоянии";
            }
            if (a >= 250000 && a <= 449000)
            {
                Finish1.text += "Авто старенькое";
            }

            /////////////////////////////////////////////////

            if (b <= 12)
            {
                Finish.text += "Шины в новом состоянии";
            }
            if (b <= 24 && b >= 13)
            {
                Finish.text += "Шины в хорошем состоянии";
            }
            if (b <= 36 && b >= 25)
            {
                Finish.text += "Шины в нормальном состоянии";
            }
            if (b >= 37)
            {
                Finish.text += "Меняй шины , они скорее всего стерты";
            }



        }
        catch (Exception)
        {
            KM.text = "Wrong Value";

        }

    }
    public void Clean()
    {
        KM.Select();
        Shina.Select();
        KM.text = "";
        Shina.text = "";
        Finish.text = "";
        Finish1.text = "";

    }
}

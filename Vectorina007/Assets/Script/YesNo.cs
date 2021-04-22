using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class YesNo : MonoBehaviour
{
    public Button Buttons;
    public Color WentedColor;
    ////////////////////////
    public Button Buttonss;
    public Color WentedColors;
    /////////////////////////
    public Button Buttonsss;
    public Color WentedColorss;
    /////////////////////////
    public Button Buttonsss1;
    public Color WentedColorss1;
    public void Yes()
    {
        ColorBlock cb = Buttons.colors;
        cb.normalColor = WentedColor;
        cb.highlightedColor = WentedColor;
        cb.pressedColor = WentedColor;
        cb.selectedColor = WentedColor;
        cb.disabledColor = WentedColor;
        Buttons.colors = cb;

        if (Buttons.interactable == true)
        {
            Buttonss.interactable = false;
            Buttonsss.interactable = false;
            Buttonsss1.interactable = false;
        }
    }
    public void No()
    {
        ColorBlock cb = Buttonss.colors;
        cb.normalColor = WentedColors;
        cb.highlightedColor = WentedColors;
        cb.pressedColor = WentedColors;
        cb.selectedColor = WentedColors;
        cb.disabledColor = WentedColors;
        Buttonss.colors = cb;
       
        if (Buttonss.interactable == true)
        {
            Buttons.interactable = false;
            Buttonsss.interactable = false;
            Buttonsss1.interactable = false;
        }
    }
    public void No1()
    {
        ColorBlock cb = Buttonsss.colors;
        cb.normalColor = WentedColorss;
        cb.highlightedColor = WentedColorss;
        cb.pressedColor = WentedColorss;
        cb.selectedColor = WentedColorss;
        cb.disabledColor = WentedColorss;
        Buttonsss.colors = cb;
        
        if (Buttonsss.interactable == true)
        {
            Buttons.interactable = false;
            Buttonss.interactable = false;
            Buttonsss1.interactable = false;
        }
    }
    public void No2()
    {
        ColorBlock cb = Buttonsss1.colors;
        cb.normalColor = WentedColorss1;
        cb.highlightedColor = WentedColorss1;
        cb.pressedColor = WentedColorss1;
        cb.selectedColor = WentedColorss1;
        cb.disabledColor = WentedColorss1;
        Buttonsss1.colors = cb;
        
        if (Buttonsss1.interactable == true)
        {
            Buttons.interactable = false;
            Buttonss.interactable = false;
            Buttonsss.interactable = false;
        }
        
    }
}

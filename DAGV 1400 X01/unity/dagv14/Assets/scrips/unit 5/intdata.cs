
using System.Globalization;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class intdata : ScriptableObject
{
    public int value;

public void UpdateValue(int number)
{
    value += number;
}

public void ReplaceValue(int number)
{
    value = number;
}
public void DisplayImage(Image img)
{
 img.fillAmount = value;

}
public void DisplayNumber(Text txt)
{
txt.text = value.ToString();

}

}

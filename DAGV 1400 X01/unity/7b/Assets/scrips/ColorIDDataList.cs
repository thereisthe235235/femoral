using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
   public List<ColorId> colorIDList;
   public ColorID CurrnetColor;
   private int num;
   public void setCurrentcolorRandomly()
   {
        num = Random.Range(0, colorIDList.Count);
        CurrnetColor = colorIDlost[num];
        Debug.Log(num);


   }
}

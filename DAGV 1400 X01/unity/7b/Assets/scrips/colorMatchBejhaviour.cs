using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorMatchBejhaviour : MatchBehaviour
{
   public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
         idobj = colorIDDataListObj.currentColor;

    }
    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;


    }
}

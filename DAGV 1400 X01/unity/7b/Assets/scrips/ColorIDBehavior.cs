using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
         idobj = colorIDDataListObj.currentColor;

    }
}
 

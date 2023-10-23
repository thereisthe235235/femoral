using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class textLabelBehavior : MonoBehaviour


{
    public Text label;
    public Floatdata dataObj;
    
    
    private void Start()
    {
        label = GetComponent<Text>();
        
    }
    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InstalledUICulture);
    }
}

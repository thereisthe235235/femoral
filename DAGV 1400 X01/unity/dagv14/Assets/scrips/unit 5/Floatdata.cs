
using UnityEngine;

[CreateAssetMenu]
public class Floatdata : ScriptableObject
{
public float value;

public void UpdateValue(float num)
{
    value += num;
}
}

using UnityEngine;

public enum CropEatType
{
    Stamina,
    Hunger
}

public class CropEatEffect
{
    public CropEatType Type;
    public float value;
}

[CreateAssetMenu(fileName = "Crop", menuName = "New Crop")]
public class CropSO : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("CropEatEffect")]
    public CropEatEffect effect;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameResource
{
    None,
    ActionPoints,
    Muuney,
    Milk,
    Cereal
}


[CreateAssetMenu(fileName = "New Card", menuName = "BaseCard")]
public class BaseCard : ScriptableObject
{

    public new string name;
    public string description;

    public Sprite artwork;

    public int actionPointsCost;
    public int lifeCycleDays;

    public GameResource requieredType;
    public int requieredQuantity;

    public GameResource producedType;
    public int producedQuantity;


    public int marketCost;

    public void Print()
    {
        Debug.Log(
            "Card Name: " + name + "\n" +
            "Description: " + description + "\n" +
            "Action Points Cost: " + actionPointsCost + "\n" +
            "Life Cycle (Days): " + lifeCycleDays + "\n" +
            "Required Resource: " + requieredQuantity + " " + requieredType + "\n" +
            "Produced Resource: " + producedQuantity + " " + producedType + "\n" +
            "Market Cost: " + marketCost
        );
    }
}

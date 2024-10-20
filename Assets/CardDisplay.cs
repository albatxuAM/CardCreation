using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public BaseCard card;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text actionPointsText;

    public Text requieredTypeText;
    public Text requieredQuantityText;

    public Text producedTypeText;
    public Text producedQuantityText;

    // Use this for initialization
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        artworkImage.sprite = card.artwork;

        actionPointsText.text = card.actionPointsCost.ToString();

        requieredTypeText.text = card.requieredType.ToString();
        requieredQuantityText.text = card.requieredQuantity.ToString();

        producedTypeText.text = card.producedType.ToString();
        producedQuantityText.text = card.producedQuantity.ToString();
    }

}

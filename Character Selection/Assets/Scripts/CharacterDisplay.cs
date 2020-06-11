using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    //display information about the character we're seeing
    [SerializeField]
    private CharacterCreationBasic[] characters;

    public Text nameText;
    public Text abilityText;
    public Text likesText;
    public Text dislikesText;
    int index;
    //this displays the information of the Asset "Character" that can be created in the Asset menu
    //you can change what kind of characters are created in the CharacterCreationBasic script
    private void toDisplay(int index)
    {
        nameText.text = "Name:\n" + characters[index].name;
        abilityText.text = "Ability:\n" + characters[index].ability;
        likesText.text = "Likes:\n" + characters[index].likes;
        dislikesText.text = "Dislikes:\n" + characters[index].dislikes;
    }
    private void Start()
    {
        toDisplay(index);
    }
    //these two functions are onClick events that happen when the button left or right are pressed
    // and cause the information displayed to change
    public void ToggleLeftInfo()
    {
        index--;
        if (index < 0)
        {
            index = characters.Length - 1;
        }
        toDisplay(index);
    }
    public void ToggleRightInfo()
    {
        index++;
        if (index > characters.Length-1)
        {
            index = 0;
        }
        toDisplay(index);
    }


}

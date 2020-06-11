using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this allows the user to create a "Character", whatever that means ( see below ), on the Asset menu, and assign the values in the inspector
//default name is "New Character" and the type of asset you're creating is "Character"
[CreateAssetMenu(fileName = "New Character", menuName = "Character")]

public class CharacterCreationBasic : ScriptableObject
{
    // can substitute these parametres for whatever is necessary for the game
    // like power, speed, defense, etc. or more specialized information
    // can even show stuff like combos and what keys to press to perform them
    public new string name;
    public string ability;
    public string likes;
    public string dislikes;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Characters : MonoBehaviour
{
    private GameObject[] charactersList;
    public CharacterCreationBasic[] charactersInfoList;
    private int index;

    private void Start()
    {
        charactersList = new GameObject[transform.childCount];
        charactersInfoList = new CharacterCreationBasic[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            charactersList[i] = transform.GetChild(i).gameObject;   
        }
        //this disables all but one, the first in line, from being displayed;
        foreach (GameObject go in charactersList)
        {
            go.SetActive(false);
        }       
        if (charactersList[0])
        {
            charactersList[0].SetActive(true);
        }
        
    }
    //this is the function applied to the onClick event on the left button
    //the function below is the applies to the right button
    //these cause the model to change
    public void ToggleLeft()
    {
        charactersList[index].SetActive(false);

        index--;
        if (index < 0)
        {
            index = charactersList.Length - 1;
            
        }
        charactersList[index].SetActive(true);
        FindObjectOfType<AudioManager>().Play("Button Click");



    }

    public void ToggleRight()
    {
        charactersList[index].SetActive(false);

        index++;
        if (index > charactersList.Length - 1)
        {
            index = 0;
            
        }

        charactersList[index].SetActive(true);
        FindObjectOfType<AudioManager>().Play("Button Click");


    }
}

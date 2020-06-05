using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] private GameObject[] charactersList;
    private int index;

    private void Start()
    {
        charactersList = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            charactersList[i] = transform.GetChild(i).gameObject;
        }
        
        foreach(GameObject go in charactersList)
        {
            go.SetActive(false);
        }
        if (charactersList[0])
        {
            charactersList[0].SetActive(true);
        }
    }

    public void ToggleLeft()
    {
        charactersList[index].SetActive(false);

        index--;
        if (index < 0)
        {
            index = charactersList.Length - 1;
        }
        charactersList[index].SetActive(true);  
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

    }
}

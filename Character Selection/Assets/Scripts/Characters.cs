using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] private GameObject[] charactersList;

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

    public void Choose(int choice)
    {
        if (charactersList[choice])
        {
            charactersList[choice].SetActive(true);
        }
    }
}

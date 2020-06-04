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
    }
}

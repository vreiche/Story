using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item
{
    public string writeit;
    public Button.ButtonClickedEvent thingToDo;
    public Button.ButtonClickedEvent thingToDo2;
}

public class CreateScrollList : MonoBehaviour
{

    public GameObject newImage;
    public List<Item> itemList;

    public Transform contentPanel;

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        foreach (var item in itemList)
        {
            GameObject Image = Instantiate(newImage) as GameObject;
        }
    }

    public void SomethingToDo()
    {
        Debug.Log("I done did something!");
    }

    public void SomethingElseToDo(GameObject item)
    {
        Debug.Log(item.name);
    }
}

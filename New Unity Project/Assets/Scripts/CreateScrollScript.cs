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

public class CreateScrollScript : MonoBehaviour
{

    public GameObject storyCard;
    public List<Item> itemList;

    public Transform contentPanel;
    public Transform myParent;

    void Start()
    {
       // PopulateList();
    }

  /* void PopulateList()
    {
        foreach (var item in itemList)
        {
            GameObject thisList = Instantiate(storyCard) as GameObject;
            thisList.transform.parent = myParent.transform;
        }
    }*/

    public void SomethingToDo()
    {
        Debug.Log("I done did something!");
        GameObject thisList = Instantiate(storyCard) as GameObject;
        thisList.transform.SetParent(myParent, false);
    }

    public void SomethingElseToDo(GameObject item)
    {
        Debug.Log(item.name);
    }
}

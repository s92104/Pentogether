using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ListController : MonoBehaviour
{
    string imagePath = "textures";
    public Sprite[] ResultImages;
    public GameObject ContentPanel;
    public GameObject ListItemPrefab;




    void Start()
    {
        
        Object[] textures = Resources.LoadAll<Sprite>(imagePath);
        ResultImages = new Sprite[textures.Length];
        for (int i = 0; i < textures.Length; i++)
        {
            ResultImages[i] = (Sprite)textures[i];
        }
        Debug.Log("Textures Loaded: " + ResultImages.Length);
        Debug.Log("Image Path: " + imagePath);

        foreach (Sprite animal in ResultImages)
        {
            GameObject element = Instantiate(ListItemPrefab) as GameObject;
           ListItemController controller = element.GetComponent<ListItemController>();
            controller.Icon.sprite = animal;
            element.transform.parent = ContentPanel.transform;
            element.transform.localScale = Vector3.one;
    }

        // 2. Iterate through the data, 
        //	  instantiate prefab, 
        //	  set the data, 
        //	  add it to panel
     
        }
    

}

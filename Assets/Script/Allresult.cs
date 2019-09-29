using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allresult : MonoBehaviour {
    // Use this for initialization
    public List<string> allsolution;
    public int stage;
    public string[] textSplit;
    void Start()
    {
        if (stage == 1)
            for (int i = 0; PlayerPrefs.HasKey("Solution01" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution01" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid01")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 2)
            for (int i = 0; PlayerPrefs.HasKey("Solution02" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution02" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid02")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 3)
            for (int i = 0; PlayerPrefs.HasKey("Solution03" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution03" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid03")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 4)
            for (int i = 0; PlayerPrefs.HasKey("Solution04" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution04" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid04")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 5)
            for (int i = 0; PlayerPrefs.HasKey("Solution05" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution05" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid05")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 6)
            for (int i = 0; PlayerPrefs.HasKey("Solution06" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution06" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid06")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 7)
            for (int i = 0; PlayerPrefs.HasKey("Solution07" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution07" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid07")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 8)
            for (int i = 0; PlayerPrefs.HasKey("Solution08" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution08" + i));
                textSplit= allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid08")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for(int j=0; j<item.transform.childCount;j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 9)
            for (int i = 0; PlayerPrefs.HasKey("Solution09" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution09" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid09")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 10)
            for (int i = 0; PlayerPrefs.HasKey("Solution10" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution10" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid10")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 11)
            for (int i = 0; PlayerPrefs.HasKey("Solution11" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution11" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid11")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 12)
            for (int i = 0; PlayerPrefs.HasKey("Solution12" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution12" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid12")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 13)
            for (int i = 0; PlayerPrefs.HasKey("Solution13" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution13" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid13")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 14)
            for (int i = 0; PlayerPrefs.HasKey("Solution14" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution14" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid14")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 15)
            for (int i = 0; PlayerPrefs.HasKey("Solution15" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution15" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid15")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 16)
            for (int i = 0; PlayerPrefs.HasKey("Solution16" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution16" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid16")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 17)
            for (int i = 0; PlayerPrefs.HasKey("Solution17" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution17" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid17")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 18)
            for (int i = 0; PlayerPrefs.HasKey("Solution18" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution18" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid18")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 19)
            for (int i = 0; PlayerPrefs.HasKey("Solution19" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution19" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid19")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 20)
            for (int i = 0; PlayerPrefs.HasKey("Solution20" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution20" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid20")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 21)
            for (int i = 0; PlayerPrefs.HasKey("Solution21" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution21" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid21")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }
        if (stage == 22)
            for (int i = 0; PlayerPrefs.HasKey("Solution22" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution22" + i));
                textSplit = allsolution[i].Split(","[0]);
                GameObject item = Instantiate(Resources.Load("Grid22")) as GameObject;
                item.GetComponent<RectTransform>().SetParent(GameObject.FindGameObjectWithTag("Result").transform);
                item.GetComponent<RectTransform>().SetAsFirstSibling();

                for (int j = 0; j < item.transform.childCount; j++)
                {
                    item.gameObject.transform.GetChild(j).GetComponent<CellSprite>().color = textSplit[j];
                }
            }

        /*for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].enabled = false;
            Debug.Log(sprites.Length);
        }
        for (int i = 0; i < Cards.Count; i++)
        {
            //ItemGameObject is my prefab pointer that i previous made a public property  
            //and  assigned a prefab to it
            GameObject card = Instantiate(ItemGameObject) as GameObject;

            //scroll = GameObject.Find("CardScroll");
            if (ScrollViewGameObject != null)
            {
                //ScrollViewGameObject container object
                card.transform.SetParent(ScrollViewGameObject.transform, false);
            }
        }*/
    }
        // Update is called once per frame
        void Update () {
		
	}
}

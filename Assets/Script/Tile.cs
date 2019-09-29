using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tile : MonoBehaviour
{
    private Vector2 startingPosition;
    private Vector2 dropPosition;
    private List<Transform> touchingTiles;
    private Transform myParent;
    private AudioSource audSource;
    public List<GameObject> child;
    public static List<Transform> touchingnothing;
    public static List<Transform> touchingonce;
    public static List<Transform> touchingtwice;
    public static List<Transform> touchingcell;
    public float dist;
    private bool move = false;
    private bool RotaFlip = true;
    public string a;


    private void Update()
    {
        if (move==true)
        {
            dropPosition = gameObject.transform.position;
            dist = Vector3.Distance(dropPosition, startingPosition);
        }
    }
    private void Awake()
    {
        myParent = transform.parent;
        audSource = gameObject.GetComponent<AudioSource>();
        touchingTiles = new List<Transform>();
        touchingnothing = new List<Transform>();
        touchingonce = new List<Transform>();
        touchingcell = new List<Transform>();
        touchingtwice = new List<Transform>();
    }
    public void Rotate()
    {
        if(dist > 0.09|| RotaFlip == false)
            return;
        gameObject.transform.Rotate(0, 0,-90);
        for (int i = 0; i <= 4; i++)
        {
            child[i].transform.parent = myParent;
            child[i].transform.localScale = new Vector3(1, 1, 1);
            child[i].GetComponent<SpriteRenderer>().sortingOrder = 0;
            child[i].GetComponent<Tile>().Dropdosomething();
        }
    }
    public void Flip()
    {
        if (dist > 0.09 || RotaFlip == false)
            return;
        gameObject.transform.Rotate(0, 180, 0);
        for (int i = 0; i <= 4; i++)
        {
            child[i].transform.parent = myParent;
            child[i].transform.localScale = new Vector3(1, 1, 1);
            child[i].GetComponent<SpriteRenderer>().sortingOrder = 0;
            child[i].GetComponent<Tile>().Dropdosomething();
        }
    }
    public void PickUp()
    {
        move = true;
        touchingnothing = new List<Transform>();
        touchingonce = new List<Transform>();
        touchingcell = new List<Transform>();
        touchingtwice = new List<Transform>();
        gameObject.transform.parent = myParent;
        startingPosition = transform.position;
        for (int i = 0; i <= 4; i++)
        {
            child[i].transform.parent = gameObject.transform;
            child[i].GetComponent<SpriteRenderer>().sortingOrder = 1;
            child[i].GetComponent<Tile>().Pickdosomething();
        }
        //gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);

    }
    public void Pickdosomething()
    {
    }
    public void Drop()
    {
        move = false;
        if (dist< 0.09)
            return;
            for (int i = 0; i <= 4; i++)
            {
                child[i].transform.parent = myParent;
                child[i].GetComponent<SpriteRenderer>().sortingOrder = 0;
                child[i].GetComponent<Tile>().Dropdosomething();
            }
        }
    public void Dropdosomething()
    {
        if (touchingTiles.Count == 1)
        {
            if (!touchingonce.Contains(this.transform))
                touchingonce.Add(this.transform);
        }
        if (touchingTiles.Count == 0)
        {
            if (!touchingnothing.Contains(this.transform))
                touchingnothing.Add(this.transform);
        }
        if (touchingTiles.Count >1)
        {
            if (!touchingtwice.Contains(this.transform))
                touchingtwice.Add(this.transform);
        }
        if (touchingonce.Count > 0)
        {
            if (touchingtwice.Count > 0 || touchingnothing.Count > 0)
            {
                for (int i = 0; i <= 4; i++)
                {
                    child[i].GetComponent<SpriteRenderer>().sortingOrder = 2;
                }
            }
        }
        else RotaFlip = true;
        if (touchingonce.Count == 5)
        {
            for (int i = 0; i <= 4; i++)
            {
                child[i].transform.localScale = new Vector3(1, 1, 1);
                child[i].GetComponent<Tile>().ChildKeep();
            }
            if (touchingcell.Count == 5)
            {
                for (int i = 0; i <= 4; i++)
                {
                    child[i].transform.localScale = new Vector3(1, 1, 1);
                    child[i].GetComponent<Tile>().Slot();
                }
            }
        }
        else RotaFlip = true; 
    }
    public void ChildStop()
    {
        transform.position = startingPosition;
        transform.parent = myParent;
    }
    public void ChildKeep()
    {
        var currentCell = touchingTiles[0];
        if (currentCell.childCount == 0)
        {
            if (!touchingcell.Contains(this.transform))
            touchingcell.Add(this.transform);
        }     
    }
    public void Slot()
    {
        Vector2 newPosition;
        var currentCell = touchingTiles[0];
        newPosition = currentCell.position;
        transform.parent = currentCell;
        StartCoroutine(SlotIntoPlace(transform.position, newPosition));
        RotaFlip = false;
    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Cell") return;
        if (!touchingTiles.Contains(other.transform))
        {
            touchingTiles.Add(other.transform);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag != "Cell") return;
        if (touchingTiles.Contains(other.transform))
        {
            touchingTiles.Remove(other.transform);
        }
    }
    IEnumerator SlotIntoPlace(Vector2 startingPos, Vector2 endingPos)
    {
        float duration = 0.1f;
        float elapsedTime = 0;
        audSource.Play();
        while (elapsedTime < duration)
        {
            transform.position = Vector2.Lerp(startingPos, endingPos, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = endingPos;
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
       
    }
}

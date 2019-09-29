using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour
{
    private bool draggingItem = false;
    private GameObject draggedObject;
    private Vector2 touchOffset;
    private float time = 0; 
    private int count = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
            time = Time.time;
            /*if (count == 1)  
            {  
                
            }   
            if(count == 2 && (Time.time - time) <= 0.2)   
            {  
                Flip();  
                count = 0;
            }*/
        }
        if (Input.GetMouseButtonUp(0) && (Time.time - time) > 0.3)
        { 
            Flip();

            }
        
        else if (Input.GetMouseButtonUp(0) && (Time.time - time) < 0.2)
        {
            Rotate();
        }
         if (HasInput)
         DragOrPickUp();
         else
          {
          if (draggingItem)
          DropItem();
        }
        }
    Vector2 CurrentTouchPosition
    {
        get
        {
           return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    private void DragOrPickUp()
    {
        var inputPosition = CurrentTouchPosition;
        if (draggingItem)
        {
            draggedObject.transform.position = inputPosition + touchOffset;
        }
        else
        {
            var layerMask = 1 << 0;
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f, layerMask);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null && hit.transform.tag == "Tile")
                {
                    draggingItem = true;
                    draggedObject = hit.transform.gameObject;
                    touchOffset = (Vector2)hit.transform.position - inputPosition;
                    hit.transform.GetComponent<Tile>().PickUp();
                }
            }
        }
    }
    private void Rotate()
    {
        var inputPosition = CurrentTouchPosition;
        var layerMask = 1 << 0;
        RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f, layerMask);
        if (touches.Length > 0)
        {
            var hit = touches[0];
            if (hit.transform != null && hit.transform.tag == "Tile")
            {
                hit.transform.GetComponent<Tile>().Rotate();
            }
        }
    }
    private void Flip()
    {
        var inputPosition = CurrentTouchPosition;
        var layerMask = 1 << 0;
        RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f, layerMask);
        if (touches.Length > 0)
        {
            var hit = touches[0];
            if (hit.transform != null && hit.transform.tag == "Tile")
            {
                hit.transform.GetComponent<Tile>().Flip();
                
            }
        }
    }
   private bool HasInput
     {
         get
         {
            // returns true if either the mouse button is down or at least one touch is felt on the screen
            return Input.GetMouseButton(0);
            
        }
     }
    void DropItem()
    {
        draggingItem = false;
        draggedObject.transform.localScale = new Vector3(1, 1, 1);
        draggedObject.GetComponent<Tile>().Drop();
    }
}
      

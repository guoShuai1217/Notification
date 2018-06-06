/*
 * 
 *   Title : "" 项目
 *
 *   Description :
 *
 *   Author : guoShuai
 *
 *   Data : 2018
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointerImg : UIBase, IDragHandler, IEndDragHandler
{
    Vector3 startPos;
    private Transform border;
    float radius;

    private void Start()
    {
        border = transform.parent.Find("border");
        startPos = transform.position;
        radius = Vector3.Distance(transform.position, border.position);
    }

    Vector3 dir;
    public void OnDrag(PointerEventData eventData)
    {
          dir = Input.mousePosition - startPos;

        if (Vector3.Distance(Input.mousePosition, startPos) < radius)
            transform.position = Input.mousePosition;
        else               
            transform.position = dir.normalized * radius + startPos;         
              

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startPos;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position,startPos) > 0)
        {
            Dispatch(AreaCode.CHARACTER, CharacterEvent.MOVE, dir);
        }
    }
}

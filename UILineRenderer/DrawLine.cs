using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI.Extensions;
public class DrawLine : MonoBehaviour, IDragHandler, IDropHandler
{
    public UILineRenderer lineRenderer;
    public Vector2 DragStartPos = Vector2.zero;
    RectTransform RT;
    Vector2 rectPos;
    int CurrentLine = 0;
    List<Vector2> points = new List<Vector2>();


    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<UILineRenderer>();
        RT = GetComponent<RectTransform>();
        rectPos = RT.position;
    }

    /// <summary>
    /// EventData/MousePosition updated every frame.  Grab the first drag start point as the beginning as the first point
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        if (DragStartPos == Vector2.zero) // New click/drag
        {
            DragStartPos = eventData.position;
            if (points.Count < 1)
            {
                //New line, add origin
                points.Add(new Vector2(DragStartPos.x - rectPos.x, DragStartPos.y - rectPos.y));
            }
            points.Add(new Vector2(DragStartPos.x - rectPos.x, DragStartPos.y - rectPos.y));
        }
        else
        {
            points[CurrentLine + 1] = new Vector2(eventData.position.x - rectPos.x, eventData.position.y - rectPos.y);
            lineRenderer.Points = points.ToArray();
            lineRenderer.SetAllDirty();
        }
    }

    /// <summary>
    /// When the user has finished clicking, add the end point and draw the line
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrop(PointerEventData eventData)
    {
        points[CurrentLine + 1] = new Vector2(eventData.position.x - rectPos.x, eventData.position.y - rectPos.y);

        //Use the gathered points and update the line renderer
        lineRenderer.Points = points.ToArray();
        lineRenderer.SetAllDirty();
        DragStartPos = Vector2.zero;
        CurrentLine += 1;
    }
}
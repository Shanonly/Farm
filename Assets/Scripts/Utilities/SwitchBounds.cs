using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwichBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        SwitchConfinerShape();
    }

    private void SwitchConfinerShape()
    {
        PolygonCollider2D confinerShape = GameObject.FindGameObjectWithTag("BoundsConfiner").GetComponent<PolygonCollider2D>();

        CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();

        confiner.m_BoundingShape2D = confinerShape;

        confiner.InvalidatePathCache();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private GridLogic grid;

    public Vector2Int sizeGrid;
    public float cellSize;
    public Vector3 originGrid;
    private void Start()
    {
        grid = new GridLogic(sizeGrid.x, sizeGrid.y, cellSize, originGrid);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = MouseScreenPositionWithoutZ();
            grid.SetValue(mousePos, 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(MouseScreenPositionWithoutZ()));
        }
    }

    private Vector3 MouseScreenPositionWithoutZ()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHeatmap : MonoBehaviour
{
    [SerializeField] private HeatMapVisual heatMapVisual;
    GridLogic grid;
    private void Start()
    {
        grid = new GridLogic(100, 100, 5f, Vector3.zero);

        heatMapVisual.SetGrid(grid);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = MouseScreenPositionWithoutZ();
            int value = grid.GetValue(mousePos);
            grid.AddValue(mousePos, 90, 10, 25);

        }
    }

    private Vector3 MouseScreenPositionWithoutZ()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}

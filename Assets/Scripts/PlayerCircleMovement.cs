using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class PlayerCircleMovement : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;
    private Vector3 _mousePosition;
    private Camera _mainCamera;
    private List<Vector3> _pathPoints;
    private int _actualPathIndex = 0;

    private void Awake()
    {
        _pathPoints = new List<Vector3>();
        _mainCamera = Camera.main;
    }

    private void Start()
    {
        _pathPoints.Add(transform.position);
        _lineRenderer.positionCount++;
        _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, transform.position);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _pathPoints.Add(ReturnClickPostion());

        if (_pathPoints.Count > 1 && transform.position == _pathPoints[_actualPathIndex] &&
            _actualPathIndex <= _pathPoints.Count - 2)
        {
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, _pathPoints[_actualPathIndex + 1]);
            Move();
        }
    }

    private Vector3 ReturnClickPostion()
    {
        Vector3 mainCamera2D = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mainCamera2D.z = 0;
        return mainCamera2D;
    }

    private void Move()
    {
        _actualPathIndex++;
        transform.DOMove(_pathPoints[_actualPathIndex], 3);
    }
}
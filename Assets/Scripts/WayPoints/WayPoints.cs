using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [SerializeField] private GameObject wayPointsParent;
    internal static List<Transform> WayPointsList { get; private set; }
    private void Awake()
    {
        WayPointsList = wayPointsParent.GetComponentsInChildren<Transform>().ToList();
        WayPointsList.RemoveAt(0);
    }
}

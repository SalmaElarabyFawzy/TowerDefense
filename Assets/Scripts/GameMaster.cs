using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject wayPointsParent;
    internal static List<Transform> WayPoints { get; private set; }
    private void Awake()
    {
        WayPoints = wayPointsParent.GetComponentsInChildren<Transform>().ToList();
        WayPoints.RemoveAt(0);
    }
}

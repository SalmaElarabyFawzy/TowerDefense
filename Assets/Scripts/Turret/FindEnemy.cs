using Unity.VisualScripting;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private string enemyTag;
    public Transform Target { get; private set; }
    private void Start()
    {
        InvokeRepeating("FindNearestEnemy",0f , 0.5f);
        Target = null;
    }

    private void FindNearestEnemy()
    {
        var enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        var shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (var enemy in enemies )
        {
            var distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance > shortestDistance)
                continue;
            shortestDistance = distance;
            nearestEnemy = enemy;
        }
        
        if (shortestDistance < range && nearestEnemy is not null) 
            Target = nearestEnemy.transform;
        else
            Target = null;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position , range);
    }
}

using UnityEngine;
using UnityEngine.AI;

namespace _Test_Project.Tools.Scripts
{
    public static class NavMeshRandomPoint
    {
        public static Vector3 GetRandomPoint(float maxDistance)
        {
            Vector3 randomPos = Random.insideUnitSphere * maxDistance;

            NavMesh.SamplePosition(randomPos, out var hit, maxDistance, NavMesh.AllAreas);

            return hit.position;
        }
    }
}
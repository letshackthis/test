using _Test_Project.Tools.Scripts;
using _Test_Project.UI.Scripts;
using UnityEngine;
using CharacterController = _Test_Project.Player.Scripts.CharacterController;

namespace _Test_Project.Collectables.Scripts
{
    public class SpawnCollectables : MonoBehaviour
    {
        [SerializeField] private Collectable[] collectables;
        [SerializeField] private Vector2 spawnMinMax;
        [SerializeField] private Transform spawnParent;
        [SerializeField] private CharacterController characterController;
        [SerializeField] private UIMediator mediator;

        private void Awake()
        {
            int spawnNumber = (int)Random.Range(spawnMinMax.x, spawnMinMax.y);
            mediator.SetCollectedAmount(spawnNumber);
            SpawnCollectable(spawnNumber);
        }

        private void SpawnCollectable(int spawnNumber)
        {
            for (int i = 0; i < spawnNumber; i++)
            {
                Collectable currentCollectable =
                    Instantiate(collectables[Random.Range(0, collectables.Length)],
                        NavMeshRandomPoint.GetRandomPoint(30f) + Vector3.up, Quaternion.identity, spawnParent);

                currentCollectable.Initialize(characterController, mediator);
            }
        }
    }
}
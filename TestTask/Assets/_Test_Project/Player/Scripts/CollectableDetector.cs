using _Test_Project.UI.Scripts;
using UnityEngine;

namespace _Test_Project.Player.Scripts
{
    public class CollectableDetector : MonoBehaviour
    {
        [SerializeField] private UIMediator mediator;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Collectable"))
            {
                if (other.TryGetComponent(out ICollectable collectable))
                    collectable?.Collect();

                other.gameObject.SetActive(false);
                mediator.UpdateCollectablesAmount();
            }
        }
    }
}
using _Test_Project.UI.Scripts;
using UnityEngine;
using UnityEngine.AI;

namespace _Test_Project.Player.Scripts
{
    public class PlayerSpeedController : MonoBehaviour
    {
        [SerializeField] private CharacterData characterData;
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private UIMediator mediator;

        private void Awake()
        {
            navMeshAgent.speed = characterData.InitSpeed;
            mediator.SetPlayerStartSpeed((int)navMeshAgent.speed);
        }

        public void ChangePlayerSpeed(int speedValue)
        {
            navMeshAgent.speed += speedValue;
        }
    }
}

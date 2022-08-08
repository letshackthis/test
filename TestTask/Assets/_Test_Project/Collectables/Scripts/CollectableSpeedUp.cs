using _Test_Project.UI.Scripts;
using UnityEngine;
using CharacterController = _Test_Project.Player.Scripts.CharacterController;

namespace _Test_Project.Collectables.Scripts
{
    public class CollectableSpeedUp : Collectable
    {
        [SerializeField] private Vector2 speedMinMaxValue;
        private int _currentSpeed;

        public override void Initialize(CharacterController controller, UIMediator mediator)
        {
            base.Initialize(controller, mediator);
            _currentSpeed = (int)Random.Range(speedMinMaxValue.x, speedMinMaxValue.y);
        }

        public override void Collect()
        {
            base.Collect();
            _characterController.MeshAgent.speed = _currentSpeed;
            _mediator.SetPlayerStartSpeed(_currentSpeed);
        }
    }
}
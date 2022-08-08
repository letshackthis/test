using _Test_Project.UI.Scripts;
using UnityEngine;
using CharacterController = _Test_Project.Player.Scripts.CharacterController;

namespace _Test_Project.Collectables.Scripts
{
    public class CollectableChangeColor : Collectable
    {
        [SerializeField] private MeshRenderer meshRenderer;
        private Color _currentColor;
        public override void Initialize(CharacterController controller, UIMediator mediator)
        {
            base.Initialize(controller, mediator);
            _currentColor = Random.ColorHSV();
            meshRenderer.material.color = _currentColor;
        }

        public override void Collect()
        {
            base.Collect();
            _characterController.MeshRenderer1.material.color = _currentColor;
        }
    }
}

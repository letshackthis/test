using _Test_Project.Player.Scripts;
using _Test_Project.Tools.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Test_Project.UI.Scripts
{
    public class BottomBar : MonoBehaviour
    {
        [SerializeField] private CharacterData characterData;
        [SerializeField] private UIMediator mediator;
        [SerializeField] private TextMeshProUGUI currentMoveSpeed;

        [SerializeField] private Button decreaseSpeedBtn, increaseSpeedBtn;

        private int _currentPlayerSpeed;

        public void SetStartPlayerSpeed(int speedValue)
        {
            _currentPlayerSpeed = speedValue;
            currentMoveSpeed.transform.ScaleAnimation(1.5f);
            currentMoveSpeed.text = speedValue.ToString();
        }

        public void ChangePlayerSpeed(int speedValue)
        {
            _currentPlayerSpeed += speedValue;
            CheckSpeedValue();
            mediator.UpdatePlayerSpeedValue(speedValue);
            currentMoveSpeed.transform.ScaleAnimation(1.5f);
            currentMoveSpeed.text = _currentPlayerSpeed.ToString();
        }

        private void CheckSpeedValue()
        {
            increaseSpeedBtn.interactable = _currentPlayerSpeed < characterData.MaxSpeed;

            decreaseSpeedBtn.interactable = _currentPlayerSpeed > characterData.MinSpeed;
        }
    }
}
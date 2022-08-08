using _Test_Project.Tools.Scripts;
using TMPro;
using UnityEngine;

namespace _Test_Project.UI.Scripts
{
    public class TopBar : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI totalCollected;
        private int _currentCollectablesAmount, _maxCollectablesAmount;

        public void SetCollectedAmount(int totalCollectables)
        {
            _maxCollectablesAmount = totalCollectables;
            UpdateCollectablesText();
        }

        public void IncreaseCurrentCollectables()
        {
            _currentCollectablesAmount++;
            UpdateCollectablesText();
        }

        private void UpdateCollectablesText()
        {
            totalCollected.transform.ScaleAnimation();
            totalCollected.text = "COLLECTED: \n" + _currentCollectablesAmount + "/" + _maxCollectablesAmount;
        }
    }
}

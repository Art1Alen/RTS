using Abstractions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserControlSystem
{
    public sealed class BottomRightPresenter : MonoBehaviour
    {
        [SerializeField] private Button _buttonAttake;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Button _buttonMove;
        [SerializeField] private TextMeshProUGUI _move;
        [SerializeField] private Button _buttonPatrol;
        [SerializeField] private TextMeshProUGUI _patrol;
        [SerializeField] private Button _buttonProtectior;
        [SerializeField] private TextMeshProUGUI _protectior;

        [SerializeField] private SelectableValue _selectedValue;

        private void Start()
        {
            _selectedValue.OnSelected += ONSelected;
            ONSelected(_selectedValue.CurrentValue);
        }

        private void ONSelected(ISelectable selected)
        {
            _buttonAttake.enabled = selected != null;
            _text.gameObject.SetActive(selected != null);
            _text.enabled = selected != null;

            _buttonMove.enabled = selected != null;
            _move.gameObject.SetActive(selected != null);
            _move.enabled = selected != null;

            _buttonPatrol.enabled = selected != null;
            _patrol.gameObject.SetActive(selected != null);
            _patrol.enabled = selected != null;

            _buttonProtectior.enabled = selected != null;
            _protectior.gameObject.SetActive(selected != null);
            _protectior.enabled = selected != null;



        }
    }
}
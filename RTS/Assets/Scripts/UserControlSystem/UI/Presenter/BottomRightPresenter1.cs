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

            //if (selected != null)
            //{
            //    _buttonAttake.sprite = selected.Icon;
            //    _text.text = $"{selected.Health}/{selected.MaxHealth}";
            //    _text = 0;
            //    _text.maxValue = selected.MaxHealth;
            //    _text.value = selected.Health;
            //    var color = Color.Lerp(Color.red, Color.green, selected.Health / (float)selected.MaxHealth);
            //    _sliderBackground.color = color * 0.5f;
            //    _sliderFillImage.color = color;
            //}
        }
    }
}
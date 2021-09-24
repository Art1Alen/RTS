using System.Linq;
using Abstractions;
using UnityEngine;
using UserControlSystem;

public sealed class MouseInteractionPresenter : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SelectableValue _selectedObject;

    private void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if(Physics.Raycast(ray, out raycastHit, 100))
        {
            var MouseInteractionPresenter = raycastHit.collider.GetComponent<MouseInteractionPresenter>();
            if(MouseInteractionPresenter != null)
            {
                Debug.Log("OnHoverEnter");
            }
            else
            {
                Debug.Log("OnHoverExit");
            }
        }

        if (!Input.GetMouseButtonUp(0))
        {
            return;
        }
        var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));
        if (hits.Length == 0)
        {
            return;
        }
        var selectable = hits
            .Select(hit => hit.collider.GetComponentInParent<ISelectable>())
            .FirstOrDefault(c => c != null);
        _selectedObject.SetValue(selectable);
    }
}
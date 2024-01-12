using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    [SerializeField] private bool _freezeXY = true;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        transform.rotation = _freezeXY ? Quaternion.Euler(Vector3.zero.With(y: _camera.transform.rotation.eulerAngles.y)) : _camera.transform.rotation;
    }
}
